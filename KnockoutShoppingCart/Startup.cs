using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnockoutShoppingCart.Startup))]
namespace KnockoutShoppingCart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
