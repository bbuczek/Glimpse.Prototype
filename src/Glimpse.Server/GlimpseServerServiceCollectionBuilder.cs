using Microsoft.Framework.DependencyInjection;

namespace Glimpse
{
    public class GlimpseServerServiceCollectionBuilder : GlimpseServiceCollectionBuilder
    {
        public GlimpseServerServiceCollectionBuilder(IServiceCollection innerCollection)
            : base(innerCollection)
        {
        }
    }
}