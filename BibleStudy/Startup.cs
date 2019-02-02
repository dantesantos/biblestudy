using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BibleStudy.Startup))]
namespace BibleStudy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
