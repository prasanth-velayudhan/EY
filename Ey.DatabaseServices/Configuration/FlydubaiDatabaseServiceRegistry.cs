using Ey.Common.Contracts.DatabaseServices;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Ey.DatabaseServices.Configuration
{

    /// <summary>
    /// Ey Database Service Registry
    /// </summary>
    public class EyDatabaseServiceRegistry : Registry
    {
        public EyDatabaseServiceRegistry()
        {
            Scan(assemblyScanner =>
            {
                assemblyScanner.TheCallingAssembly();
                assemblyScanner.WithDefaultConventions();
            });

            //this.For<EyContext>();
            //this.For<IRepository>().Use<Repository>();
        }
    }
}