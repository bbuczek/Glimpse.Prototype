using Glimpse.Agent.Razor;
using Glimpse.Common.Initialization;
using Microsoft.AspNet.Mvc.Razor;
using Microsoft.Framework.DependencyInjection;

namespace Glimpse.Agent.AspNet.Mvc.Razor
{
    public class RazorServices : IRegisterServices
    {
        public void RegisterServices(GlimpseServiceCollectionBuilder services)
        {
            services.AddTransient<IMvcRazorHost, ScriptInjectorRazorHost>();
        }
    }
}