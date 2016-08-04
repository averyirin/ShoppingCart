using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP2007_S2016_Lesson12A.Startup))]
namespace COMP2007_S2016_Lesson12A
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
