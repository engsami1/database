using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddEmployes.Startup))]
namespace AddEmployes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
