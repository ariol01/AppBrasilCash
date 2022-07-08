using AppBrasilCash.Application.Interface.AppService;
using AppBrasilCash.Application.Service;
using AppBrasilCash.Dominio.Models.Interface.Api;
using AppBrasilCash.Dominio.Models.Service.Api;
using AppBrasilCash.Models.Interface.Repository;
using AppBrasilCash.Models.Interface.Service;
using AppBrasilCash.Models.Service;
using AppCashBrasil.Infra;
using AppCashBrasil.Infra.Repository;
using Microsoft.EntityFrameworkCore;

namespace AppBrasilCash
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(op =>
            {
                op.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddScoped<IAccountAppService, AccountAppService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IViaCepApi,ViaCepApi>();

        }
        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
