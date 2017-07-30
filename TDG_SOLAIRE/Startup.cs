using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDG_SOLAIRE.Startup))]
namespace TDG_SOLAIRE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
