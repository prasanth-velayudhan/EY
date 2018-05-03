using flydubai.Common.Contracts.DatabaseServices;
using StructureMap.Configuration.DSL;

namespace flydubai.DatabaseServices.Configuration
{

    /// <summary>
    /// Flydubai Database Service Registry
    /// </summary>
    public class FlydubaiDatabaseServiceRegistry : Registry
    {
        public FlydubaiDatabaseServiceRegistry()
        {
            Scan(assemblyScanner =>
            {
                assemblyScanner.TheCallingAssembly();
                assemblyScanner.WithDefaultConventions();
            });

            this.For<FlydubaiContext>().HttpContextScoped();
            this.For<IRepository>().HttpContextScoped().Use<Repository>();
        }
    }
}