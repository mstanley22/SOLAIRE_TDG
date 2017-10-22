namespace Context.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.SolaireContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.SolaireContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            SetupSolaireRoles(context);
        }

        void SetupSolaireRoles(SolaireContext context)
        {
           


            if (!context.Roles.Any(a => a.Name == "Admin"))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var role = new IdentityRole
                {
                    Name = "Admin"
                };
                roleManager.Create(role);
            }
            var userStore = new UserStore<ApplicationUser>(context);
            var manager = new ApplicationUserManager(userStore);



            if (!context.Users.Any(u =>  u.Email == "Admin@Solaire.com"))
            {
                var user = new ApplicationUser
                {
                    Email = "Admin@Solaire.com",
                    UserName = "Admin@Solaire.com",

                };
                var result = manager.Create(user, "Admin1");

                if (result.Succeeded) manager.AddToRole(user.Id, "Admin");

            }
            else
            {
                //var user = userStore.FindByEmailAsync("admin@yopmail.com").Result;

                //userStore.AddClaimAsync(user, claim: new Claim(ClaimTypes.Role.ToString(), "Admin")).Start();
            }

           

        }
    }
}
