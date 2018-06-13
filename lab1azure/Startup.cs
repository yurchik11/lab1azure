using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab1azure.Startup))]
namespace lab1azure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
