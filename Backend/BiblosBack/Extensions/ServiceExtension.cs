using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace BiblosBack.Extensions
{
    public static class ServiceExtension
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(opt =>
            {
                List<string> xmlFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.xml", searchOption: SearchOption.TopDirectoryOnly).ToList();
                xmlFiles.ForEach(xmlFile => opt.IncludeXmlComments(xmlFile));

                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "BiblosBack Api",
                    Description = "Api for the Waiters of a Restaurant",
                    Contact = new OpenApiContact
                    {
                        Name = "Dream Team",
                        Email = "losmasduros@gmail.com",
                        Url = new Uri("https://www.dreamteam.com")
                    }
                });

                opt.DescribeAllParametersInCamelCase();
            });
        }

        public static void AddApiVersioningExtension(this IServiceCollection service)
        {
            service.AddApiVersioning(conf =>
            {
                conf.DefaultApiVersion = new ApiVersion(1, 0);
                conf.AssumeDefaultVersionWhenUnspecified = true;
                conf.ReportApiVersions = true;
            });
        }
    }
}
