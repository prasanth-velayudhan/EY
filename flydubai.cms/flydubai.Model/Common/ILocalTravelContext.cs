namespace flydubai.Model.Common
{
    using System;

    /// <summary>
    /// Interface of LocalTravelContext
    /// </summary>
    public interface ILocalTravelContext
    {
        string Origin { get; }

        string Destination { get; }

        /// <summary>
        /// The departure time in the <see cref="Origin">Origin's</see> local time.
        /// </summary>
        DateTime DepartureDate { get; }

        /// <summary>
        /// The arrival time in the <see cref="Destination">Destination's</see> local time.
        /// </summary>
        DateTime ArrivalDate { get; }
    }
}