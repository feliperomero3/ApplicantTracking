using Microsoft.Owin;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using Unity.Lifetime;

[assembly: OwinStartup(typeof(ApplicantTracking.Web.Startup))]
namespace ApplicantTracking.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            UnityConfig.Container.RegisterInstance(typeof(IDataProtectionProvider), 
                null, app.GetDataProtectionProvider(), new TransientLifetimeManager());

            ConfigureAuth(app);
        }
    }
}
