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

            //this.For<IRadixxSession>().Use<UserSession>();            
        }
    }
}