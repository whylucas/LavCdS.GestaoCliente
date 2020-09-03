using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using LavCdS.GestaoCliente.Domain.Interface;
using LavCdS.GestaoCliente.Domain.Model;
using LavCdS.GestaoCliente.Infrastructure.Repositories.PostgreSQL;
using LavCdS.GestaoCliente.Application.Application;


namespace LavCdS.GestaoCliente
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
            services.AddSingleton<IBuscaCliente, BuscaCliente>();
            services.AddSingleton<IClienteRepository, ClienteRepository>();
            services.AddSingleton(typeof(IConfiguration), this.Configuration);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

        }
    }
}
