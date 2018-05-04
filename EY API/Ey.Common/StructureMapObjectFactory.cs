using System;
using System.Threading;
using StructureMap;

namespace Ey.Common
{
    public static class StructureMapObjectFactory

    {
       // private static readonly Lazy<Container> _containerBuilder =
        //    new Lazy<Container>(() => new Container(), LazyThreadSafetyMode.ExecutionAndPublication);
 
        public static IContainer Container
        {
            get { return null; //_containerBuilder.Value; 
            }
        }

        public static void Initialize<T>() where T : Registry, new()
        {
            //Container.Configure(x =>
            //{
            //    x.AddRegistry<T>();
            //});
        }
    }
}