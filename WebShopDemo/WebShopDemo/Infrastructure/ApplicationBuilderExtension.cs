using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDemo.Data;
using WebShopDemo.Domain;

namespace WebShopDemo.Infrastructure
{
    public static class ApplicationBuilderExtension
    {
        public static async Task<IApplicationBuilder> PrepareDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();

            var services = serviceScope.ServiceProvider;

            await RoleSeeder(services);
            await SeedAdministrator(services);

            var dataCategory = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedCategories(dataCategory);

            var dataBrand = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedBrands(dataBrand);
            return app;
        }

        private static async Task RoleSeeder(IServiceProvider services)
        {
            public static async Task<ApplicationBuilder> PreparedDatabase(this IApplicationBuilder app)
            {
                using var serviceScope = app.ApplicationServices.CreateScope();

                var services = serviceScope.ServiceProvider;

                await RoleSeeder(services);
                await SeedAdministrator(services);
                return app;
            }
        }

        private static async Task RoleSeeder((IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string[] roleNames = { "Administrator", "Client" };

            IdentityResult roleResult;

            foreach (var role in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);

                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        
            private static async Task SeedAdministrator(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            if (await userManager.FindByNameAsync("admin") == null)
            {
                ApplicationUser User = new ApplicationUser();
                User.FirstName = "admin";
                User.LastName = "admin";
                User.PhoneNumber = "0888888888";
                User.UserName = "admin";
                User.Email = "admin@admin.com";

                var result = await userManager.CreateAsync
                    (User, "KingAdmin");

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(User, "Administrator").Wait();
                }

            }
        }

        private static void SeedCategories(ApplicationDbContext dataCategory)
        {
            if (dataCategory.Categories.Any())
            {
                return;
            }
            dataCategory.Categories.AddRange(new[]
            {
                new Category { CategoryName = "Laptot" },
                new Category { CategoryName = "Computer" },
                new Category { CategoryName = "Monitor" },
                new Category { CategoryName = "Accessory" },
                new Category { CategoryName = "TV" },
                new Category { CategoryName = "Mobile phone" },
                new Category { CategoryName = "Smart watch" }
            });
            dataCategory.SaveChanges();
        }
        private static void SeedBrands(ApplicationDbContext dataCategory)
        {
            if (dataCategory.Brands.Any())
            {
                return;
            }
            dataCategory.Brands.AddRange(new[]
            {
                new Brand { BrandName = "Acer" },
                new Brand { BrandName = "Asus" },
                new Brand { BrandName = "Apple" },
                new Brand { BrandName = "HP" },
                new Brand { BrandName = "Huawei" },
                new Brand { BrandName = "Lenovo" },
                new Brand { BrandName = "Samsung" }
            });
            dataCategory.SaveChanges();
        }
    }
}




    