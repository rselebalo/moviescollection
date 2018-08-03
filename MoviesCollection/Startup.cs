using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesCollection.Startup))]
namespace MoviesCollection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
