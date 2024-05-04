using Application.Services.ImageService;
using Application.Services.PDFService;
using Infrastructure.Adapters.ImageService;
using Infrastructure.Adapters.PDFService;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<ImageServiceBase, CloudinaryImageServiceAdapter>();
        //services.AddScoped<FileUploadServiceBase>(sp => new LocalFileUploadService("Path/To/Store/PDFs"));
        services.AddScoped<PDFServiceBase, CloudinaryPDFServiceAdapter>();

        return services;
    }
}
