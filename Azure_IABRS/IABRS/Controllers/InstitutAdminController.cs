using IABRS.Models;
using IABRS.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IABRS.Controllers
{
    [Authorize(Roles = "InstituteAdmin")]
    public class InstitutAdminController : Controller
    {
        testsForNADContext dbCon = new testsForNADContext();
        static readonly string instituteAdmin = "InstituteAdmin";
        public RoleManager<IdentityRole> RoleManager { get; }
        public UserManager<User> UserManager { get; }
        public ILogger<SysAdminController> Logger { get; }      


        public InstitutAdminController(RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager, ILogger<SysAdminController> logger)
        {
            RoleManager = roleManager;
            UserManager = userManager;
            Logger = logger;
            logger.Log(LogLevel.Information, "Accessed SysAdminController");
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListUsers()
        {
            var curUser = await UserManager.GetUserAsync(HttpContext.User);
            bool inrole = await UserManager.IsInRoleAsync(curUser, "InstituteAdmin");
            string domain = curUser.NormalizedEmail.Split('@')[1];
            List<User> users = new List<User>();
            foreach (User user in dbCon.User)
            {
                if (user.NormalizedEmail.Split("@")[1] == domain && ! await UserManager.IsInRoleAsync(user, "SysAdmin"))
                {
                    
                    users.Add(user);
                }
            }         
            return View(users);
        }
    }
}