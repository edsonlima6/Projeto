using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBI_Identity.Startup))]
namespace MyBI_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
