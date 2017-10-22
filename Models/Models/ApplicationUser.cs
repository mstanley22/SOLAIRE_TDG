﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;


namespace Models.Models
{
    public class ApplicationUser : IdentityUser
    {

        public ApplicationUser()
        {

        }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            LastLogin = DateTime.Now;
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);



            // Add custom user claims here
            return userIdentity;
        }

        public StatusType StatusType { get; set; }

        public DateTime? LastLogin { get; set; }

    }
}
