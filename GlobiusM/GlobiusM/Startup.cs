using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlobiusM.Startup))]
namespace GlobiusM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
