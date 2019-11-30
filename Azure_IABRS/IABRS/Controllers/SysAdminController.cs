using IABRS.Models;
using IABRS.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IABRS.Controllers
{
    public class SysAdminController:Controller
    {
        public SysAdminController(RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager)
        {
            RoleManager = roleManager;
            UserManager = userManager;
        }

        public RoleManager<IdentityRole> RoleManager { get; }
        public UserManager<User> UserManager { get; }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await RoleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "sysadmin");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

           
            return View(model);
        }
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = RoleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
           var role = await RoleManager.FindByIdAsync(id);

            if (role == null)
            {
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

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel rmodel)
        {
            var role = await RoleManager.FindByIdAsync(rmodel.Id);

            if (role == null)
            {
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

                return View(rmodel);
            }
        }
        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await RoleManager.FindByIdAsync(roleId);

            if (role == null)
            {
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
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await RoleManager.FindByIdAsync(roleId);

            if (role == null)
            {
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
            }
            return View();
        }
    }
}
