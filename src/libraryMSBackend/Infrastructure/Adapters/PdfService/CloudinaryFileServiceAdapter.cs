using Application.Services.PDFService;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Infrastructure.Adapters.PDFService
{
    public class CloudinaryPDFServiceAdapter : PDFServiceBase
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryPDFServiceAdapter(IConfiguration configuration)
        {
            Account account = configuration.GetSection("CloudinaryAccount").Get<Account>();
            _cloudinary = new Cloudinary(account);
        }

        public override async Task<string> UploadAsync(IFormFile formFile)
        {
            await FileMustBeInPDFFormat(formFile);

            RawUploadParams uploadParams = new()
            {
                File = new FileDescription(formFile.FileName, stream: formFile.OpenReadStream()),
                UseFilename = false,
                UniqueFilename = true,
                Overwrite = false
            };

            RawUploadResult uploadResult = await _cloudinary.UploadAsync(uploadParams);
            return uploadResult.Url.ToString();
        }

        public override async Task DeleteAsync(string fileUrl)
        {
            DeletionParams deletionParams = new(GetPublicId(fileUrl));
            await _cloudinary.DestroyAsync(deletionParams);
        }

        private string GetPublicId(string fileUrl)
        {
            int startIndex = fileUrl.LastIndexOf('/') + 1;
            int endIndex = fileUrl.LastIndexOf('.');
            int length = endIndex - startIndex;
            return fileUrl.Substring(startIndex, length);
        }
    }
}