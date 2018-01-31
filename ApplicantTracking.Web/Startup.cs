using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicantTracking.Web.Startup))]
namespace ApplicantTracking.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
