using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIT.ERP.Solucion.Startup))]
namespace CIT.ERP.Solucion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
