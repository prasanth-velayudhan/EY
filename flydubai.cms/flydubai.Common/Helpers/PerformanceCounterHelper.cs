using System.Diagnostics;

namespace flydubai.Common.Helpers
{
    /// <summary>
    /// Helper class to create, read and write FZ performance counters (# Radixx calls / sec)
    /// </summary>
    public static class PerformanceCounterHelper
    {
        private const string CategoryName = "Flydubai";

        private const string ConcurrentRadixxCalls = "# Concurrent Radixx calls";

        private static PerformanceCounter radixxCallsPerformanceCounter = null;

        private static readonly object PerfLock = new object();

        /// <summary>
        /// Returns the Radixx calls per second remote performance counter (singleton)
        /// </summary>
        /// <returns>Radixx calls per second performance counter</returns>
        public static PerformanceCounter GetRadixxCallsPerformanceCounter(bool readOnly = false)
        {
            if (radixxCallsPerformanceCounter == null)
            {
                lock (PerfLock)
                {
                    if (radixxCallsPerformanceCounter == null)
                    {
                        radixxCallsPerformanceCounter = new PerformanceCounter(CategoryName, ConcurrentRadixxCalls, readOnly);

                        if (!readOnly)
                        {
                            radixxCallsPerformanceCounter.RawValue = 0;
                        }

                    }
                }
            }

            return radixxCallsPerformanceCounter;
        }

        /// <summary>
        /// Returns the Radixx calls per second remote performance counter (read only because writing is not possible)
        /// </summary>
        /// <param name="machineName">The remote machine name</param>
        /// <returns>Radixx calls per second performance counter</returns>
        public static PerformanceCounter GetRadixxCallsPerformanceCounter(string machineName)
        {
            var performanceCounter = GetRadixxCallsPerformanceCounter(true);
            performanceCounter.MachineName = machineName;

            return performanceCounter;
        }

        /// <summary>
        /// Creates a new performance category (Flydubai) and counter (# Radixx calls / sec)
        /// </summary>
        public static void CreateFlydubaiPerformaceCounters()
        {
            if (!PerformanceCounterCategory.Exists(CategoryName))
            {
                var counters = new CounterCreationDataCollection
                    {
                        new CounterCreationData(
                            ConcurrentRadixxCalls,
                            "Number of Concurrent Radixx calls at the same time",
                            PerformanceCounterType.NumberOfItems32)
                    };

                PerformanceCounterCategory.Create(
                    CategoryName,
                    "Flydubai Web 2.0 Performance counters",
                    PerformanceCounterCategoryType.SingleInstance,
                    counters);
            }
        }

        /// <summary>
        /// Creates a new performance category (Flydubai) and counter (# Radixx calls / sec)
        /// </summary>
        public static void DeleteFlydubaiPerformaceCounters()
        {
            if (PerformanceCounterCategory.Exists(CategoryName))
            {
                PerformanceCounterCategory.Delete(CategoryName);
            }
        }
    }
}
