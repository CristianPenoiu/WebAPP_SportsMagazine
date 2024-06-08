using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class LoginService
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginService> _logger;

        public LoginService(SignInManager<IdentityUser> signInManager, ILogger<LoginService> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<SignInResult> SignInAsync(string email, string password, bool rememberMe)
        {
            return await _signInManager.PasswordSignInAsync(email, password, rememberMe, lockoutOnFailure: false);
        }

        public async Task<IEnumerable<AuthenticationScheme>> GetExternalAuthenticationSchemesAsync()
        {
            return await _signInManager.GetExternalAuthenticationSchemesAsync();
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
