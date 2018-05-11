using StructureMap.Configuration.DSL;
//using Ey.Model;
using StructureMap;
using StructureMap.Graph;

namespace Ey.Services.Configuration
{
    public class EyServicesRegistry : Registry
    {
        public EyServicesRegistry()
        {
            Scan(assemblyScanner =>
            {
                assemblyScanner.TheCallingAssembly();
                assemblyScanner.WithDefaultConventions();
            });

            this.For<Services.SabreFareQuote.SSSAdvShopPortType>().Use(new Services.SabreFareQuote.SSSAdvShopPortTypeClient()).Singleton();

            //this.For<IRadixxSession>().Use<UserSession>();            
        }
    }
}