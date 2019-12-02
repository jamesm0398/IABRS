using IABRS.Models;
using IABRS.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IABRS.Controllers
{

    [Authorize(Roles = "SysAdmin,InstituteAdmin")]   
    public class SysAdminController:Controller
    {
        static readonly string sysAdmin = "SysAdmin";
        testsForNADContext dbCon = new testsForNADContext();
      
        public SysAdminController(RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager, ILogger<SysAdminController> logger)
        {
            RoleManager = roleManager;
            UserManager = userManager;
            Logger = logger;
            logger.Log(LogLevel.Information, "Accessed SysAdminController");
        }

        public RoleManager<IdentityRole> RoleManager { get; }
        public UserManager<User> UserManager { get; }
        public ILogger<SysAdminController> Logger { get; }


        [HttpPost]
        [Authorize(Roles = "SysAdmin")]
        public async Task<IActionResult> ManageUserRoles(List<UserRolesViewModel> model, string userId)
        {
            
                var user = await UserManager.FindByIdAsync(userId);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                    return View("NotFound");
                }

                var roles = await UserManager.GetRolesAsync(user);
                var result = await UserManager.RemoveFromRolesAsync(user, roles);

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Cannot remove user existing roles");
                    return View(model);
                }

                result = await UserManager.AddToRolesAsync(user,
                    model.Where(x => x.IsSelected).Select(y => y.RoleName));

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Cannot add selected roles to user");
                    return View(model);
                }

                return RedirectToAction("EditUser", new { Id = userId });
            }

        [HttpPost]
        [Authorize(Roles = "SysAdmin")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            Logger.Log(LogLevel.Information, "Attempting to Delete user Id: {0} , UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
            var user = await UserManager.FindByIdAsync(id);

            if (user == null)
            {
                Logger.Log(LogLevel.Error, "Attempting to Delete user Id: {0} Failed to find user, UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                //dbCon.InstitutionUser.FromSql("DELETE FROM [dbo].[InstitutionUser] iu WHERE iu.UserId = {0}", id);
                dbCon.SaveChanges();
                var result = await UserManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    Logger.Log(LogLevel.Error, "Delete user Id: {0} User deleted, UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("ListUsers");
            }
        }

        [HttpPost]
        [Authorize(Roles = "SysAdmin")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            Logger.Log(LogLevel.Information, "Attempting to Delete role Id: {0} , UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
            if (role == null)
            {
                Logger.Log(LogLevel.Error, "Attempting to Delete role Id: {0} Failed to find role, UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await RoleManager.DeleteAsync(role);

                if (result.Succeeded)
                {
                    Logger.Log(LogLevel.Information, "Delete role Id: {0} role deleted, UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("ListRoles");
            }
        }

        [HttpGet]
        [Authorize(Roles = "SysAdmin")]
        public IActionResult ListUsers()
        {
            Logger.Log(LogLevel.Information, "User {0} Accessed ListUsers, UserIsAdmin: {1}", User.ToString(), User.IsInRole(sysAdmin));
            var users = UserManager.Users;
            return View(users);
        }


        [HttpGet]
        //[Authorize(Roles = "SysAdmin,InstituteAdmin")]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await UserManager.FindByIdAsync(id);
            Logger.Log(LogLevel.Information, "Attempting to edit user Id: {0} , UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
            if (user == null)
            {
                Logger.Log(LogLevel.Error, "Attempting to edit user Id: {0} Failed to find user, UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            // GetClaimsAsync retunrs the list of user Claims
            var userClaims = await UserManager.GetClaimsAsync(user);
            // GetRolesAsync returns the list of user Roles
            var userRoles = await UserManager.GetRolesAsync(user);

            var model = new EditUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
               // City = user.City,
                Claims = userClaims.Select(c => c.Value).ToList(),
                Roles = userRoles
            };
            Logger.Log(LogLevel.Information, "Edited user Id: {0} , UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
            return View(model);
        }


        [HttpPost]
       // [Authorize(Roles = "SysAdmin, InstituteAdmin")]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            Logger.Log(LogLevel.Information, "Attempting to edit user Id: {0} , UserIsAdmin: {1}", model.Id, User.IsInRole(sysAdmin));
            var user = await UserManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                Logger.Log(LogLevel.Error, "Attempting to edit user Id: {0} Failed to find user, UserIsAdmin: {1}", model.Id, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;
              //  user.City = model.City;

                var result = await UserManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    
                    if (User.IsInRole("InstituteAdmin"))
                    {
                        return RedirectToAction("ListUsers", "InstitutAdmin");
                    }
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                Logger.Log(LogLevel.Information, "Edited user Id: {0} , UserIsAdmin: {1}", model.Id, User.IsInRole(sysAdmin));
                return View(model);
            }
        }

        [HttpPost]
        [Authorize(Roles = "SysAdmin")]
        public async Task<IActionResult> DeleteInstitution(int id)
        {
            Logger.Log(LogLevel.Information, "Attempting to Delete Institution Id: {0} , UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
            var inst = await dbCon.Institution.FindAsync(id);

            if (inst == null)
            {
                Logger.Log(LogLevel.Error, "Attempting to Delete Institution Id: {0} Failed to find user, UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"Institution with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                try
                {
                    dbCon.Institution.Remove(inst);
                    if (dbCon.SaveChanges() == 1)
                    {
                        Logger.Log(LogLevel.Error, "Delete Institution Id: {0} Institution deleted, UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
                        return RedirectToAction("ListInstitutions");
                    }

                    
                    ModelState.AddModelError("", "Could not delete Institution");
                    

                    return View("ListUsers");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Could not delete Institution Error:" + ex.Message);
                    return View();
                }

            }
        }

        [HttpGet]
        public IActionResult EditInstitution(int id)
        {
            var inst = dbCon.Institution.Find(id);// UserManager.FindByIdAsync(id);
            Logger.Log(LogLevel.Information, "Attempting to edit Institution Id: {0} , UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
            if (inst == null)
            {
                Logger.Log(LogLevel.Error, "Attempting to edit Institution Id: {0} Failed to find Institution, UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"Institution with Id = {id} cannot be found";
                return View("NotFound");
            }

            var courses = dbCon.Course.Where(x => x.InstitutionId == id).ToList();

            var model = new EditInstitutionViewModel
            {
                Id = inst.Id,
                Domian = inst.Domain,
                Name = inst.Name,
                Courses = courses
            };
            Logger.Log(LogLevel.Information, "Institution user Id: {0} , UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> EditInstitution(EditInstitutionViewModel model)
        {
            Logger.Log(LogLevel.Information, "Attempting to edit Institution Id: {0} , UserIsAdmin: {1}", model.Id, User.IsInRole(sysAdmin));
            var inst = await dbCon.Institution.FindAsync(model.Id);

            if (inst == null)
            {
                Logger.Log(LogLevel.Error, "Attempting to edit Institution Id: {0} Failed to find Institution, UserIsAdmin: {1}", model.Id, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"Institution with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                inst.Domain = model.Domian;
                inst.Name = model.Name;
              
                var result = dbCon.Institution.Update(inst);
                
                if (dbCon.SaveChanges() == 1)
                {
                    Logger.Log(LogLevel.Information, "Edited Institution Id: {0} , UserIsAdmin: {1}", model.Id, User.IsInRole(sysAdmin));
                    return RedirectToAction("ListInstitutions");
                }

                ModelState.AddModelError("", "Could not save entry. Error saving to data base");
                
                return View(model);
            }
        }

        [HttpGet]
        [Authorize(Roles = "SysAdmin")]
        public IActionResult ListInstitutions()
        {
            Logger.Log(LogLevel.Information, "User {0} Accessed ListInstitutions, UserIsAdmin: {1}", User.ToString(), User.IsInRole(sysAdmin));
            var users = dbCon.Institution;
            return View(users);
        }
        [HttpGet]
        [Authorize(Roles = "SysAdmin")]
        public IActionResult RegisterInstitution()
        {

            return View();
        }
        [HttpPost]
        [Authorize(Roles = "SysAdmin")]
        public IActionResult RegisterInstitution(CreateInstitutionViewModel model)
        {
            Logger.Log(LogLevel.Information, "Accessed Register Institution, UserIsAdmin: {1}", User.IsInRole(sysAdmin));
            if (ModelState.IsValid)
            {
                Institution inst = new Institution
                {
                    Name = model.InstituteName,
                    Domain = model.InstituteDomain
                };

                List<Institution> res = dbCon.Institution.Where(x => x.Name == inst.Name && x.Domain == inst.Domain).ToList();
              
                if (res.Count == 0)
                {
                    var added =dbCon.Institution.Add(inst);
                    if (dbCon.SaveChanges() == 1)
                    {
                        Logger.Log(LogLevel.Information, "Register intitution model was Created, UserIsAdmin: {1}", User.IsInRole(sysAdmin));
                        return RedirectToAction("ListInstitutions", "sysadmin");
                    }
                    ModelState.AddModelError("", "Could not save entry. Error saving to data base");
                    return View(model);
                }

                
                ModelState.AddModelError("", "This institution already exists with this domain");
                
            }
            Logger.Log(LogLevel.Error, "Register intitution model was not valid, UserIsAdmin: {1}", User.IsInRole(sysAdmin));

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "SysAdmin")]
        public IActionResult CreateRole()
        {
           
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "SysAdmin")]
        public async Task< IActionResult> CreateRole(CreateRoleViewModel model)
        {
            Logger.Log(LogLevel.Information, "Accessed CreateRole, UserIsAdmin: {1}",  User.IsInRole(sysAdmin));
            if (ModelState.IsValid)
            {
                
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await RoleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    Logger.Log(LogLevel.Information, "CreateRole model was Created, UserIsAdmin: {1}", User.IsInRole(sysAdmin));
                    return RedirectToAction("ListRoles", "sysadmin");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            Logger.Log(LogLevel.Information, "CreateRole model was not valid, UserIsAdmin: {1}", User.IsInRole(sysAdmin));

            return View(model);
        }
        [HttpGet]
        [Authorize(Roles = "SysAdmin")]
        public IActionResult ListRoles()
        {
            Logger.Log(LogLevel.Information, "Accessed ListRoles, UserIsAdmin: {1}", User.IsInRole(sysAdmin));
            if (User.IsInRole(sysAdmin))
            {
                var roles = RoleManager.Roles;
                return View(roles);
            }
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "SysAdmin")]
        public async Task<IActionResult> EditRole(string id)
        {
           var role = await RoleManager.FindByIdAsync(id);
            Logger.Log(LogLevel.Information, "Accessed EditRole role Id: {0} , UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
            if (role == null)
            {
                Logger.Log(LogLevel.Error, "Failed to find role Id: {0} , UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach (var user in UserManager.Users)
            {
                if (await UserManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            Logger.Log(LogLevel.Information, "EditRole found role Id: {0} , UserIsAdmin: {1}", id, User.IsInRole(sysAdmin));
            return View(model);

        }

        [HttpPost]
        [Authorize(Roles = "SysAdmin")]
        public async Task<IActionResult> EditRole(EditRoleViewModel rmodel)
        {

            var role = await RoleManager.FindByIdAsync(rmodel.Id);
            Logger.Log(LogLevel.Information, "Accessed EditRole role Id: {0} , UserIsAdmin: {1}", rmodel.Id, User.IsInRole(sysAdmin));
            if (role == null)
            {
                Logger.Log(LogLevel.Error, "Failed to find role Id: {0} , UserIsAdmin: {1}", rmodel.Id, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"Role with Id = {rmodel.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = rmodel.RoleName;
                var result = await RoleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                Logger.Log(LogLevel.Information, "EditRole found role Id: {0} , UserIsAdmin: {1}", rmodel.Id, User.IsInRole(sysAdmin));
                return View(rmodel);
            }
        }
        [HttpGet]
        [Authorize(Roles = "SysAdmin")]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;
            Logger.Log(LogLevel.Information, "Accessed EditUsersInRole role Id: {0} , UserIsAdmin: {1}", roleId, User.IsInRole(sysAdmin));
            var role = await RoleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                Logger.Log(LogLevel.Error, "failed to find role Id: {0} , UserIsAdmin: {1}", roleId, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"Role with id = {roleId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            foreach (var user in UserManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if (await UserManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }
            Logger.Log(LogLevel.Information, "found {0} users in role Id: {1} , UserIsAdmin: {2}", model.Count, roleId, User.IsInRole(sysAdmin));
            return View(model);
        }



        [HttpGet]
        [Authorize(Roles = "SysAdmin")]
        public async Task<IActionResult> ManageUserRoles(string userId)
        {
            ViewBag.userId = userId;

            var user = await UserManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRolesViewModel>();

            foreach (var role in RoleManager.Roles)
            {
                var userRolesViewModel = new UserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                if (await UserManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.IsSelected = true;
                }
                else
                {
                    userRolesViewModel.IsSelected = false;
                }

                model.Add(userRolesViewModel);
            }

            return View(model);
        }


        [HttpPost]
        [Authorize(Roles = "SysAdmin")]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await RoleManager.FindByIdAsync(roleId);
            Logger.Log(LogLevel.Information, "Accessed EditUsersInRole user count: {0} role Id: {1} , UserIsAdmin: {2}", model.Count, roleId, User.IsInRole(sysAdmin));
            if (role == null)
            {
                Logger.Log(LogLevel.Error, "Failed to find role Id: {0} , UserIsAdmin: {1}", roleId, User.IsInRole(sysAdmin));
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await UserManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await UserManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await UserManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await UserManager.IsInRoleAsync(user, role.Name))
                {
                    result = await UserManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i<(model.Count -1))
                    {
                        continue;
                    }
                    else
                    {
                        return RedirectToAction("EditRole", new { Id = roleId });
                    }
                }
            }
            return RedirectToAction("EditRole", new { Id = roleId });
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            Logger.Log(LogLevel.Warning, "AccessDenied SysAdminController user : {0} , UserIsAdmin: {1}", User.ToString(), User.IsInRole(sysAdmin));
            return View();
        }
    }
}
