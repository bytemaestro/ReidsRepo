using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KleinTech.Web.MVC5.Startup))]
namespace KleinTech.Web.MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
