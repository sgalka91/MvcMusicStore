using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;
using System.Data.Entity;
using System.Web.Security;
using Microsoft.AspNet.Identity;

namespace MvcMusicStore.Controllers
{
    public class SteveController : Controller
    {
        public string Galka()
        {

            ApplicationUser steve = null;
            using (ApplicationDbContext db = ApplicationDbContext.Create())
            {
                steve = db.Users.FirstOrDefault(f => f.Email == "sgalka91@gmail.com");
            }
            return "Steve Galka ID: " + steve.PasswordHash;
        }
     }
}