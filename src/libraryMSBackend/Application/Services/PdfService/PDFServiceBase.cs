using Microsoft.AspNetCore.Http;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.PDFService
{
    public abstract class PDFServiceBase
    {
        public abstract Task<string> UploadAsync(IFormFile formFile);

        public async Task<string> UpdateAsync(IFormFile formFile, string fileUrl)
        {
            await FileMustBeInPDFFormat(formFile);
            await DeleteAsync(fileUrl);
            return await UploadAsync(formFile);
        }

        public abstract Task DeleteAsync(string fileUrl);

        protected async Task FileMustBeInPDFFormat(IFormFile formFile)
        {
            List<string> extensions = new() { ".pdf" };
            string extension = Path.GetExtension(formFile.FileName).ToLower();

            if (!extensions.Contains(extension))
            {
                throw new BusinessException("Unsupported format, expected PDF.");
            }

            await Task.CompletedTask;
        }
    }
}