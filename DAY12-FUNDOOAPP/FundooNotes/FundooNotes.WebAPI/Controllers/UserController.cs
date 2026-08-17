using System.Security.Claims;
using FundooNotes.Business.Interfaces;
using FundooNotes.Common.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FundooNotes.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        // POST api/user/register
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _userManager.RegisterAsync(dto);
            return result.Success ? Ok(result) : Conflict(result);
        }

        // POST api/user/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _userManager.LoginAsync(dto);
            return result.Success ? Ok(result) : Unauthorized(result);
        }

        // POST api/user/forgot-password
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _userManager.ForgotPasswordAsync(dto);
            return Ok(result); // always 200 to avoid leaking which emails are registered
        }

        // PUT api/user/reset-password
        // PUT because the client supplies the full new state (token + new password) via a link, not a partial update.
        [HttpPut("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _userManager.ResetPasswordAsync(dto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        // PATCH api/user/change-password
        // PATCH because it's a partial update (just the password field) on an already-authenticated user.
        [Authorize]
        [HttpPatch("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)
                ?? User.FindFirstValue("sub")!);

            var result = await _userManager.ChangePasswordAsync(userId, dto);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        // GET api/user/profile - simple protected endpoint proving the JWT works end to end
        [Authorize]
        [HttpGet("profile")]
        public IActionResult Profile()
        {
            var email = User.FindFirstValue(ClaimTypes.Email) ?? User.FindFirstValue("email");
            var firstName = User.FindFirstValue("firstName");
            return Ok(new { email, firstName });
        }
    }
}