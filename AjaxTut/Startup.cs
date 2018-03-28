using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxTut.Startup))]
namespace AjaxTut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
