using Blog.MiddlerServices;
using Blog.MiddlerServices.Quartz;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.API
{
    public class ServiceCollectionManager
    {
        public ServiceCollectionManager(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            this.HostingEnvironment = hostingEnvironment;
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment HostingEnvironment { get; }
        public void AddService(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1.1.0",
                    Title = ".NET Core WebAPI",
                    Description = "后台框架",
                    Contact = new OpenApiContact()
                    {
                        Name = "张子浩",
                        Email = "zaranet@163.com",
                        Url = new Uri("https://www.cnblogs.com/zaranet/")
                    }
                });
            });
            services.AddSingleton<IConfiguration>(new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .AddJsonFile($"appsettings.{this.HostingEnvironment.EnvironmentName.ToLower()}.json")
               .Build());

            services.AddCors(options => options.AddPolicy("Domain",
                builder => builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()));

            services.AddQuartz(typeof(ScheduledJob));
        }
    }
}
