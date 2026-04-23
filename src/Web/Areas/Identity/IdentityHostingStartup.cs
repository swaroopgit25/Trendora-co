[assembly: HostingStartup(typeof(Trendora.Web.Areas.Identity.IdentityHostingStartup))]
namespace Trendora.Web.Areas.Identity;

public class IdentityHostingStartup : IHostingStartup
{
    public void Configure(IWebHostBuilder builder)
    {
        builder.ConfigureServices((context, services) =>
        {
        });
    }
}

