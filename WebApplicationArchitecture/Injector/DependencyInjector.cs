using Data.Context;
using Data.Helpers;
using Data.Repositories;
using Domain.Repositories.Interfaces;
using Domain.Services;
using Domain.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Injector
{
    public class DependencyInjector
    {
        #region [API]
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            RegisterDbConnections(services, configuration);
            RegisterRepositories(services);
            RegisterServices(services);
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            #region Base
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            //services.AddScoped<IEmailRepository, EmailRepository>();
            //services.AddScoped<IAuthRepository, AuthRepository>();
            #endregion

            #region Tasy
            services.AddScoped<IBookRepository, BookRepository>();
            #endregion
        }

        private static void RegisterServices(IServiceCollection services)
        {
            #region Base
            //services.AddScoped<IEmailService, EmailService>();
            //services.AddScoped<IAuthService, AuthService>();
            #endregion

            #region Tasy
            services.AddScoped<IBookService, BookService>();
            #endregion
        }

        private static void RegisterDbConnections(IServiceCollection services, IConfiguration configuration)
        {
            #region Tasy

            services.AddDbContext<BookContext>(options => options.UseSqlServer(new SqlConn(
                configuration.GetSection("Connections:BookSQLServer:DataSource").Value,
                configuration.GetSection("Connections:BookSQLServer:Catalog").Value,
                configuration.GetSection("Connections:BookSQLServer:UserId").Value
                ).ToString()), ServiceLifetime.Singleton);

            #endregion
        }
        #endregion
    }
}