using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jquery_Ajax.Startup))]
namespace Jquery_Ajax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
