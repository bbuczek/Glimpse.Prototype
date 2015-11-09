using Glimpse.Internal;
using Microsoft.Framework.DependencyInjection;

namespace Glimpse
{
    public class GlimpseServiceCollectionBuilder : ServiceCollectionWrapper
    {
        public GlimpseServiceCollectionBuilder(IServiceCollection innerCollection) 
            : base(innerCollection)
        {
        }
    }
}