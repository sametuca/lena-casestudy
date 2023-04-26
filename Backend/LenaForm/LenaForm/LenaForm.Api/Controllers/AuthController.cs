using LenaForm.Api.Models;
using LenaForm.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Threading.Tasks;

namespace LenaForm.Api.Controllers
{
    [Route("api/auth/")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new AppUser { UserName = model.email, Email = model.email };
            var result = await _userManager.CreateAsync(user, model.password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
                return Ok(new { message = "Kayıt başarılı" });
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _signInManager.PasswordSignInAsync(model.username, model.password, true, false);

            if (result.Succeeded)
            {
                return Ok(new { message = "Giriş başarılı" });
            }
            else
            {
                return Unauthorized(new { message = "Kullanıcı adı veya şifre yanlış" });
            }
        }

        [HttpPost("role")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateRole([FromBody] RoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var role = new AppRole { Name = model.Name };
            var result = await _roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return Ok(new { message = "Rol başarıyla oluşturuldu" });
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }


    }
}
