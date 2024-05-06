using System.Text;
using Application.Features.BookIssues.Queries.GetById;
using Application.Features.BookIssues.Queries.GetList;
using Application.Features.BookReservations.Queries.GetById;
using Application.Features.BookReservations.Queries.GetList;
using Application.Features.FineDues.Commands.Create;
using Application.Features.FineDues.Queries.GetById;
using Application.Features.FineDues.Queries.GetList;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using Nest;
using Newtonsoft.Json;

var baseurl = "http://localhost:60805/";
var client = new HttpClient();
await UserPenalties();
await CleanOldBookReservationsAsync();
async Task<T> AsyncGet<T>(string url)
{
    var response = await client.GetAsync(url);
    var responseString = await response.Content.ReadAsStringAsync();
    var result = JsonConvert.DeserializeObject<T>(responseString);
    return result;
}

async Task UserPenalties()
{
    var reservationsList = await AsyncGet<GetListResponse<GetListBookIssueListItemDto>>(
        $"{baseurl}api/BookIssues?PageIndex=0&PageSize=1000"
    );
    var result = reservationsList.Items;

    foreach (var item in result)
    {
        var today = DateTime.Now;
        var returnDate = item.ReturnDate;
        var day = today - returnDate;
        double daysDifference = day.TotalDays;
        var bookIssueId = item.Id;

        if (daysDifference > 0)
        {
            double penaltyAmount = daysDifference * 3;

            // FineDue kontrolü
            var existingBookIssue = await AsyncGet<GetByIdBookIssueResponse>($"{baseurl}api/BookIssues/{bookIssueId}");
            foreach (var FineDue in existingBookIssue.FineDues)
            {
                var existingFineDue = await AsyncGet<GetByIdFineDueResponse>($"{baseurl}api/FineDues/{FineDue.Id}");

                if (existingFineDue != null)
                {
                    // Var olan FineDue güncelleniyor
                    existingFineDue.FineTotal = (decimal)penaltyAmount;
                    existingFineDue.FineDate = DateTime.Now;

                    var json = JsonConvert.SerializeObject(existingFineDue);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var updateResponse = await client.PutAsync($"{baseurl}api/FineDues", content);
                }
            }
            if (existingBookIssue.FineDues.Count == 0)
            {
                // Yeni FineDue ekleniyor
                FineDue newFineDue = new FineDue()
                {
                    FineDate = DateTime.Now,
                    BookIssueId = bookIssueId,
                    FineTotal = (decimal)penaltyAmount
                };

                var json = JsonConvert.SerializeObject(newFineDue);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var postResponse = await client.PostAsync($"{baseurl}api/FineDues", content);
            }
        }
    }
}
async Task CleanOldBookReservationsAsync()
{
    var reservationsList = await AsyncGet<GetListResponse<GetListBookReservationListItemDto>>(
        $"{baseurl}api/BookReservations?PageIndex=0&PageSize=1000"
    );
    var reservations = reservationsList.Items;

    foreach (var item in reservations)
    {
        var today = DateTime.Now;
        var requestDate = item.RequestDate;
        var daysDifference = (today - requestDate).TotalDays;

        if (daysDifference > 2) // İki günden fazla
        {
            // Öncelikle rezervasyon var mı kontrol edin
            var existingReservation = await AsyncGet<GetByIdBookReservationResponse>($"{baseurl}api/BookReservations/{item.Id}");

            if (existingReservation != null) // Rezervasyon var ise
            {
                // Rezervasyonu sil
                var deleteResponse = await client.DeleteAsync($"{baseurl}api/BookReservations/{item.Id}");
                if (!deleteResponse.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Rezervasyon {item.Id} silinemedi. Hata: {deleteResponse.ReasonPhrase}");
                }
                else
                {
                    Console.WriteLine($"Rezervasyon {item.Id} başarıyla silindi.");
                }
            }
        }
    }
}

Console.ReadLine();
