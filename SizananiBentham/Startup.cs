using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SizananiBentham.Startup))]
namespace SizananiBentham
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
