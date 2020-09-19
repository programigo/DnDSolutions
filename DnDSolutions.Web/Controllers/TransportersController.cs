using DnDSolutions.Data.Models;
using DnDSolutions.Web.Models.Transporters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DnDSolutions.Web.Controllers
{
    public class TransportersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger _logger;

        public TransportersController(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ILogger<TransportersController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<IActionResult> Details(string id)
        {
            User user = await _userManager.FindByIdAsync(id);

            TrailerType trailerTypes = user.TrailerType;
            ComodityType comodityTypes = user.ComodityType;

            TransporterDetailsViewModel result = new TransporterDetailsViewModel
            {
                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.PhoneNumber,
                TrailerTypes = GetTrailers(trailerTypes),
                ComodityTypes = GetComodities(comodityTypes),
            };

            return View(result);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterTransporterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Username,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    TrailerType = (TrailerType)model.TrailerType.Cast<int>().Sum(),
                    ComodityType = (ComodityType)model.ComodityType.Cast<int>().Sum(),
                    PhoneNumber = model.Phone,
                };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded && user.IsApproved)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    _logger.LogInformation("User created a new account with password.");

                    return RedirectToLocal(returnUrl);
                }
                else
                {
                    var returnResult = new IdentityResult();
                    AddErrors(returnResult);
                    return RedirectToAction(nameof(AccountController.Login), "Account");
                }

            }

            return View(model);
        }

        private List<string> GetComodities(ComodityType comodityTypes)
        {
            List<string> result = new List<string>();
            List<string> resultComodityTypes = new List<string>();

            foreach (ComodityType comodityType in Enum.GetValues(typeof(ComodityType)))
            {
                if ((comodityTypes & comodityType) != 0)
                {
                    result.Add(comodityType.ToString());
                }
            }

            Regex regex = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z])|(?<=[A-Za-z])(?=[^A-Za-z])");

            foreach (string s in result)
            {
                resultComodityTypes.Add(regex.Replace(s, " "));
            }

            return resultComodityTypes;
        }

        private List<string> GetTrailers(TrailerType trailerTypes)
        {
            List<string> result = new List<string>();
            List<string> resultTrailerTypes = new List<string>();

            foreach (TrailerType trailerType in Enum.GetValues(typeof(TrailerType)))
            {
                if ((trailerTypes & trailerType) != 0)
                {
                    result.Add(trailerType.ToString());
                }
            }

            Regex regex = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z])|(?<=[A-Za-z])(?=[^A-Za-z])");

            foreach (string s in result)
            {
                resultTrailerTypes.Add(regex.Replace(s, " "));
            }

            return resultTrailerTypes;
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
    }
}
