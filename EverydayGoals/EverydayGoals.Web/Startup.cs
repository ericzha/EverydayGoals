using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EverydayGoals.Web.Startup))]
namespace EverydayGoals.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
