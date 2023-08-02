using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkC

namespace CloneProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            _ = services.AddScoped<IUserDal, EFUsersRepository>();
            services.AddScoped<IUsersService, UsersManager>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // Eğer kimlik doğrulama kullanacaksanız ekleme yapın
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "login",
                    pattern: "{controller=Login}/{action=Login}");
                endpoints.MapControllerRoute(
                    name: "twitterHome",
                pattern: "/twitterhome",
             defaults: new { controller = "Home", action = "TwitterHome" });

                //endpoints.MapControllerRoute(
                //   name: "addUser",
                //   pattern: "{controller=User}/{action=AddUser}");

            });

        }
    }
}




