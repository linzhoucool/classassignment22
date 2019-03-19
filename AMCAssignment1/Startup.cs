using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AMCAssignment1.Startup))]
namespace AMCAssignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
