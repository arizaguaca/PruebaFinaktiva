
using Domain.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Persistence.Database.Context;
using Persistence.Repositories;
using System.Text;


namespace Config.Container
{
    public class Container
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<DbContext, DataContext>();

            #region Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion

            #region Business
            services.AddScoped<IUserBM, UserBM>();
 
            services.AddScoped<ILoginBM, LoginBM>();
            #endregion
            

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            #region Conection

            services.AddDbContext<DataContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );

            #endregion
        }
    }
}
