using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionCursos.Startup))]
namespace GestionCursos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
