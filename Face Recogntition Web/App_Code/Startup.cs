using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Face_Recogntition_Web.Startup))]
namespace Face_Recogntition_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
