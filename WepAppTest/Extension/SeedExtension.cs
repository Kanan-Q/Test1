using Microsoft.AspNetCore.Identity;
using WepAppTest.Enums;
using WepAppTest.Models;

namespace WepAppTest.Extension
{
    public static class SeedExtension
    {
        //public static void UseUserSeed(this IApplicationBuilder app)
        //{
        //    using (var scope = app.ApplicationServices.CreateScope())
        //    {
        //        var UserManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
        //        var RoleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();


        //        if (!RoleManager.Roles.Any())
        //        {
        //            foreach (Roles item in Enum.GetValues(typeof(Roles)))
        //            {
        //                RoleManager.CreateAsync(new IdentityRole(item.ToString())).Wait();
        //            }
        //        }
        //        if (!UserManager.Users.Any(x => x.Name == "ADMIN"))
        //        {
        //            User u = new User
        //            {
        //                Name = "admin",
        //                Surname = "admin",
        //                Email = "admin@mail.ru",
        //            };
        //            UserManager.CreateAsync(u, "" + "+Aa123***").Wait();
        //            UserManager.AddToRoleAsync(u, nameof(Roles.Admin)).Wait();
        //        }

        //    }
        //}
    }
}
