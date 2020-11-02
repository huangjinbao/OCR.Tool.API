using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace OCR.Tool.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostEnvironment hostEnvironment)
        {
            Configuration = configuration;
            HostEnvironment = hostEnvironment;
        }

        public IConfiguration Configuration { get; }
        public IHostEnvironment HostEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1-preview", new OpenApiInfo
                    {
                        Version = "v1-preview",
                        Title = "OCR Form Recognizer API (v1-preview)",
                        Description = "OCR Form Recognizer API (v1-preview) (ASP.NET Core 3.1)",
                        // Contact = new OpenApiContact()
                        // {
                        //     Name = "Swagger Codegen Contributors",
                        //     Url = new Uri("https://github.com/swagger-api/swagger-codegen"),
                        //     Email = ""
                        // },
                    });
                    //c.CustomSchemaIds(type => type.FullName);
                    c.IncludeXmlComments($"{AppContext.BaseDirectory}{Path.DirectorySeparatorChar}{HostEnvironment.ApplicationName}.xml");
                    // Sets the basePath property in the Swagger document generated
                    //c.DocumentFilter<BasePathFilter>("/formrecognizer/v2.1-preview.1");

                    // Include DataAnnotation attributes on Controller Action parameters as Swagger validation rules (e.g required, pattern, ..)
                    // Use [ValidateModelState] on Actions to actually validate it in C# as well!
                    //c.OperationFilter<GeneratePathParamsValidationFilter>();
                });

            services.AddCors(q =>
            {
                q.AddPolicy("allowAll", builder =>
                {
                    builder.AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors("allowAll");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger(q => { q.RouteTemplate = "swagger/{documentName}/swagger.json"; });
            app.UseSwaggerUI(q =>
            {
                q.RoutePrefix = "swagger";
                q.SwaggerEndpoint("v1-preview/swagger.json", "OCR.Tool.API");
            });
        }
    }
}