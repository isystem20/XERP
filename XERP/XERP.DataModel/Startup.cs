using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XERP.DataModel.SYSTEM;

namespace XERP.DataModel
{
    public class Startup
    {
        public IConfiguration configuration { get; }

        public Startup(IConfiguration config)
        {
            configuration = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Setting up the Connection String from appsettings.json
            services.AddDbContext<AuthenticationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("AuthenticationServer")));

            services.AddDefaultIdentity<ApplicationUsers>()
                .AddEntityFrameworkStores<AuthenticationContext>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
