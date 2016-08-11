using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductBidApp.Startup))]
namespace ProductBidApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
