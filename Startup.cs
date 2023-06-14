using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientVie.Startup))]
namespace ClientVie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
