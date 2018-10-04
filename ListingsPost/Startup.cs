using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ListingsPost.Startup))]
namespace ListingsPost
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
