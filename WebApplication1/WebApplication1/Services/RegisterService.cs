using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Encodings.Web;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class RegisterService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterService> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterService(UserManager<IdentityUser> userManager, ILogger<RegisterService> logger, IEmailSender emailSender)
        {
            _userManager = userManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        public async Task<IdentityResult> RegisterUserAsync(ApplicationUser user, string password, string role, string emailConfirmationUrl)
        {
            var result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                _logger.LogInformation("User created a new account with password.");
                await _userManager.AddToRoleAsync(user, role);

                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = emailConfirmationUrl.Replace("{userId}", user.Id).Replace("{code}", code);

                await _emailSender.SendEmailAsync(user.Email, "Confirm your email",
                    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                return result;
            }
            return result;
        }
    }
}
