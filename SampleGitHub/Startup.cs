using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleGitHub.Startup))]
namespace SampleGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
