using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChemicalShifts.API.AutoMapper;
using ChemicalShifts.Infra.Data.Root;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace ChemicalShifts.API
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<BaseContext>(options => options.UseMySql(Configuration.GetConnectionString("DB")), ServiceLifetime.Scoped);


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "CHemical Shifts API",
                        Version = "v1",
                        Description = "Rest API for CHemical Shifts",
                        Contact = new Contact
                        {
                            Name = "Jairo Jr",
                            Url = "https://www.linkedin.com/in/jairossjr/",
                        }
                    });

                c.IncludeXmlComments($"{System.AppDomain.CurrentDomain.BaseDirectory}ChemicalShifts.API.xml");
            });

            services.AddSingleton(new AutoMapperConfig());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "ChemicalShifts API");
            });
        }
    }
}
