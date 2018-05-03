using System.Diagnostics;

namespace Ey.Common.Helpers
{
    /// <summary>
    /// Helper class to create, read and write Ey performance counters (# sabre calls / sec)
    /// </summary>
    public static class PerformanceCounterHelper
    {
        private const string CategoryName = "Ey";

        private const string ConcurrentsabreCalls = "# Concurrent sabre calls";

        private static PerformanceCounter sabreCallsPerformanceCounter = null;

        private static readonly object PerfLock = new object();

        /// <summary>
        /// Returns the sabre calls per second remote performance counter (singleton)
        /// </summary>
        /// <returns>sabre calls per second performance counter</returns>
        public static PerformanceCounter GetsabreCallsPerformanceCounter(bool readOnly = false)
        {
            if (sabreCallsPerformanceCounter == null)
            {
                lock (PerfLock)
                {
                    if (sabreCallsPerformanceCounter == null)
                    {
                        sabreCallsPerformanceCounter = new PerformanceCounter(CategoryName, ConcurrentsabreCalls, readOnly);

                        if (!readOnly)
                        {
                            sabreCallsPerformanceCounter.RawValue = 0;
                        }

                    }
                }
            }

            return sabreCallsPerformanceCounter;
        }

        /// <summary>
        /// Returns the sabre calls per second remote performance counter (read only because writing is not possible)
        /// </summary>
        /// <param name="machineName">The remote machine name</param>
        /// <returns>sabre calls per second performance counter</returns>
        public static PerformanceCounter GetsabreCallsPerformanceCounter(string machineName)
        {
            var performanceCounter = GetsabreCallsPerformanceCounter(true);
            performanceCounter.MachineName = machineName;

            return performanceCounter;
        }

        /// <summary>
        /// Creates a new performance category (Ey) and counter (# sabre calls / sec)
        /// </summary>
        public static void CreateEyPerformaceCounters()
        {
            if (!PerformanceCounterCategory.Exists(CategoryName))
            {
                var counters = new CounterCreationDataCollection
                    {
                        new CounterCreationData(
                            ConcurrentsabreCalls,
                            "Number of Concurrent sabre calls at the same time",
                            PerformanceCounterType.NumberOfItems32)
                    };

                PerformanceCounterCategory.Create(
                    CategoryName,
                    "Ey Web 2.0 Performance counters",
                    PerformanceCounterCategoryType.SingleInstance,
                    counters);
            }
        }

        /// <summary>
        /// Creates a new performance category (Ey) and counter (# sabre calls / sec)
        /// </summary>
        public static void DeleteEyPerformaceCounters()
        {
            if (PerformanceCounterCategory.Exists(CategoryName))
            {
                PerformanceCounterCategory.Delete(CategoryName);
            }
        }
    }
}
