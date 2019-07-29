using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LojaAcessoriosInformatica.Startup))]
namespace LojaAcessoriosInformatica
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
