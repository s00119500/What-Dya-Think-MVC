using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhatDyaThink.Startup))]
namespace WhatDyaThink
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
