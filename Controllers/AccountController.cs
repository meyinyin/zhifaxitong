using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zhongyiCore.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public class Input { 
            public string username { get; set; }
            public string OldPassword { get; set; }
            public string NewPassword { get; set; }
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 注销
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPost()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Manger", new { IsSuccess = true });
        }
        public ActionResult ChangePassword(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(InputModel inputModel)
        {
            var user = await _userManager.GetUserAsync(User);
            var changePasswordResult = await _userManager.ChangePasswordAsync(user, inputModel.OldPassword, inputModel.NewPassword);
            if (!changePasswordResult.Succeeded) {
                return RedirectToAction("ChangePassword", new { IsSuccess = false });
            }
                return RedirectToAction("ChangePassword", new { IsSuccess = true });
        }
    }
}
