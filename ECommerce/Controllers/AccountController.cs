using ECommerce.BLL.Constants;
using ECommerce.BLL.Services;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.MVC.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWishlistItemService _wishlistItemService;
        private readonly IProductService _productService;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IWishlistItemService userWishlistItemService, IProductService productService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _wishlistItemService = userWishlistItemService;
            _productService = productService;
        }

        [Authorize]
        public IActionResult Dashboard()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user == null)
            {
                ModelState.AddModelError("", "Username or password is incorrect!");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or password is incorrect!");
                return View(model);
            }

            if (!string.IsNullOrEmpty(model.ReturnUrl))
            {
                return Redirect(model.ReturnUrl);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new AppUser
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,

            };



            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.Code, item.Description);
                }

                return View(model);
            }

            var roleResult = await _roleManager.CreateAsync(new IdentityRole { Name = "Client" });


            await _userManager.AddToRoleAsync(user, "Client");

            return RedirectToAction("Login", "Account");
        }

        public IActionResult AccessDenied(string returnUrl)
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Edit()
        {
            var username = User.Identity!.Name ?? "";

            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
                return BadRequest();

            var editAccountViewModel = new EditAccountViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,

            };


            return View(editAccountViewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(EditAccountViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);


            var username = User.Identity!.Name ?? "";

            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
                return BadRequest();


            if (!string.IsNullOrEmpty(model.CurrentPassword) && !string.IsNullOrEmpty(model.NewPassword))
            {
                var resultPassword = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (!resultPassword.Succeeded)
                {
                    foreach (var error in resultPassword.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
            }

            if (model.Email != user.Email /*&& !string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(user.Email)*/)
            {
                var resultEmail = await _userManager.SetEmailAsync(user, model.Email);
                if (!resultEmail.Succeeded)
                {
                    foreach (var error in resultEmail.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View(model);
                }
            }

            if (model.FirstName != user.FirstName)
                user.FirstName = model.FirstName;

            if (model.LastName != user.LastName)
                user.LastName = model.LastName;

            var resultTotal = await _userManager.UpdateAsync(user);

            if (!resultTotal.Succeeded)
            {
                foreach (var error in resultTotal.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return RedirectToAction(nameof(Index));

        }


    }
}