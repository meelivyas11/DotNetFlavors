using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVVC_App.Startup))]
namespace MVVC_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
