using Ey.Common.Exceptions;
using Ey.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Services
{
    /// <summary>
    /// Helper class to reuse the WCF Channel creation and have more control over performance and error handling
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <remarks></remarks>
    public class ServiceChannelFactory<T> where T : IClientChannel
    {
        private static readonly object PadLock = new object();
        //private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();
        private static PerformanceCounter sabreCallsPerformanceCounter;

        private static ChannelFactory<T> channelFactory;

        /// <summary>
        /// Gets the channel factory.
        /// </summary>
        /// <remarks></remarks>
        public static ChannelFactory<T> ChannelFactory
        {
            get
            {
                if (channelFactory == null)
                {
                    lock (PadLock)
                    {
                        if (channelFactory == null)
                        {
                            bool isBetaSite = Convert.ToBoolean(ConfigurationManager.AppSettings["IsBetaSite"]);

                            channelFactory = new ChannelFactory<T>(ConfigurationManager.AppSettings[typeof(T).Name + "EndPoint"]);

                            if (isBetaSite)
                            {
                                sabreCallsPerformanceCounter = PerformanceCounterHelper.GetsabreCallsPerformanceCounter();
                            }
                        }
                    }
                }
                return channelFactory;
            }
        }

        /// <summary>
        /// Executes the specified code block.
        /// </summary>
        /// <typeparam name="Result">The type of the esult.</typeparam>
        /// <param name="codeBlock">The code block.</param>
        /// <returns>The result</returns>
        /// <remarks></remarks>
        public static Result Func<Result>(Func<T, Result> codeBlock)
        {
            Result result = default(Result);
            T channel = ChannelFactory.CreateChannel();
            bool success = false;
            bool isBetaSite = Convert.ToBoolean(ConfigurationManager.AppSettings["IsBetaSite"]);

            try
            {
                if (isBetaSite)
                {
                    lock (sabreCallsPerformanceCounter)
                    {
                        sabreCallsPerformanceCounter.RawValue++;
                    }
                }

                channel.Open();
                DateTime startTime = DateTime.UtcNow;
                result = codeBlock(channel);
                var wcfServiceName = codeBlock.Method.Name.Substring(1, codeBlock.Method.Name.IndexOf('>') - 1);
                var wcfServiceTotalSeconds = (DateTime.UtcNow - startTime).TotalSeconds.ToString("0.##");
                channel.Close();
                success = true;
            }
            catch (FaultException ex)
            {
                throw new EyServiceException("WCF Fault Exeption", ex);
            }
            catch (CommunicationException ex)
            {
                throw new EyServiceException("WCF Communication Exception", ex);
            }
            catch (TimeoutException ex)
            {
                throw new EyServiceException("WCF Timeout", ex);
            }
            finally
            {
                if (isBetaSite)
                {
                    lock (sabreCallsPerformanceCounter)
                    {
                        if (sabreCallsPerformanceCounter.RawValue > 0)
                        {
                            sabreCallsPerformanceCounter.RawValue--;
                        }
                    }
                }

                if (!success)
                {
                    channel.Abort();
                }
            }
            return result;
        }

        /// <summary>
        /// Actions the specified code block.
        /// </summary>
        /// <param name="codeBlock">The code block.</param>
        /// <remarks></remarks>
        public static void Action(Action<T> codeBlock)
        {
            var channel = ChannelFactory.CreateChannel();
            bool success = false;
            bool isBetaSite = Convert.ToBoolean(ConfigurationManager.AppSettings["IsBetaSite"]);

            try
            {
                if (isBetaSite)
                {
                    lock (sabreCallsPerformanceCounter)
                    {
                        sabreCallsPerformanceCounter.RawValue++;
                    }
                }

                channel.Open();
                codeBlock(channel);
                channel.Close();
                success = true;
            }
            finally
            {
                if (isBetaSite)
                {
                    lock (sabreCallsPerformanceCounter)
                    {
                        if (sabreCallsPerformanceCounter.RawValue > 0)
                        {
                            sabreCallsPerformanceCounter.RawValue--;
                        }
                    }
                }

                if (!success)
                {
                    channel.Abort();
                }
            }
        }
    }
}
