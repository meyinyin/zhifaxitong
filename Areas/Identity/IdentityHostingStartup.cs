using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using zhongyiCore.Data;

[assembly: HostingStartup(typeof(zhongyiCore.Areas.Identity.IdentityHostingStartup))]
namespace zhongyiCore.Areas.Identity
{
    //public class IdentityHostingStartup : IHostingStartup
    //{
    //    public void Configure(IWebHostBuilder builder)
    //    {
    //        builder.ConfigureServices((context, services) => {
    //            services.AddDbContext<zhongyiCoreContext>(options =>
    //                options.UseSqlServer(
    //                    context.Configuration.GetConnectionString("zhongyiCoreContextConnection")));

    //            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    //                .AddEntityFrameworkStores<zhongyiCoreContext>();
    //        });
    //    }
    //}
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}