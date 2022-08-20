using CotacaoMoeda.Repositories;
using CotacaoMoeda.Repositories.Contexts;
using CotacaoMoeda.Repositories.Interfaces;
using CotacaoMoeda.Services;
using CotacaoMoeda.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotacaoMoeda
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CotacaoMoeda", Version = "v1" });
            });

            services.AddDbContext<Context>(c => c.UseNpgsql("Server=localhost;Port=5432;Database=CasaDaMoeda;User Id=postgres;Password=makelifesimple;"));
            services.AddScoped<IMoedaRepository, MoedaRepository>();
            services.AddScoped<ICotacaoRepository, CotacaoRepository>();

            services.AddScoped<IMoedaService, MoedaService>();
            services.AddScoped<ICotacaoService, CotacaoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CotacaoMoeda v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
