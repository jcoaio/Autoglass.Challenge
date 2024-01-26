using Autoglass.Challenge.Application.Interfaces;
using Autoglass.Challenge.Application.Service;
using Autoglass.Challenge.Domain.Interfaces;
using Autoglass.Challenge.Domain.Services;
using Autoglass.Challenge.Infra;
using Autoglass.Challenge.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Autoglass.Challenge.IoC
{
    public class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            // Services
            services.AddTransient<IProdutoService, ProdutoService>();
            services.AddTransient<IProdutoApplicationService, ProdutoApplicationService>();
            services.AddTransient<IFornecedorService, FornecedorService>();
            services.AddTransient<IFornecedorApplicationService, FornecedorApplicationService>();



            // Repositories
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();

            services.AddDbContext<AutoglassDbContext>(
                options => options.UseSqlite(configuration.GetConnectionString("SqliteDB"))
            );
        }
    }
}
