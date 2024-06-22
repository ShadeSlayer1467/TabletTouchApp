using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IO;

public class ConfigurationService
{
    public IConfiguration Configuration { get; }

    public ConfigurationService()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("secrets.json", optional: false, reloadOnChange: true);

        Configuration = builder.Build();
    }

    public string GetVendorId()
    {
        return Configuration["DeviceSettings:VendorId"];
    }

    public string GetProductId()
    {
        return Configuration["DeviceSettings:ProductId"];
    }
}
