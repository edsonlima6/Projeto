using System.Security.Claims;
using System.Threading.Tasks;
using EP.IdentityIsolation.Infra.CrossCutting.Identity.Model;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;

namespace EP.IdentityIsolation.Infra.CrossCutting.Identity.Configuration
{
    public class ApplicationSignInManager2 : SignInManager<ApplicationUser, string>
    {
        public ApplicationSignInManager2(ApplicationUserManager2 userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {

        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager2)UserManager);                
        }

        public static ApplicationSignInManager2 Create(IdentityFactoryOptions<ApplicationSignInManager2> options, IOwinContext context)
        {
            return new ApplicationSignInManager2(context.GetUserManager<ApplicationUserManager2>(), context.Authentication);
        }
    }
}
