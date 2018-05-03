using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.Schedule
{
    /// <summary>
    /// Flight Schedule
    /// </summary>
    [Serializable]
    public class FlightSchedule : IEquatable<FlightSchedule>
    {
        public string FlightNumber { get; set; }

        public string OriginCode { get; set; }

        public string DestinationCode { get; set; }

        public string DepartureTime { get; set; }

        public string ArrivalTime { get; set; }

        public int DaysDifference { get; set; }

        public int NumberStops { get; set; }

        public DateTime EffectiveFrom { get; set; }

        public DateTime EffectiveTo { get; set; }

        public List<Enums.RadixxDayOfWeek> DaysOperating { get; set; }

        public string Duration { get; set; }

        public string DurationText
        {
            get
            {
                string durationText = this.Duration;

                if (!string.IsNullOrEmpty(this.Duration))
                {
                    //expected format is hh:mm - if over 1 day then it goes to e.g. 26:44
                    string[] timeBits = this.Duration.Split(':');
                    if (timeBits.Length == 2)
                    {
                        durationText = string.Format("{0}h {1}m", timeBits[0], timeBits[1]);
                    }
                }
                return durationText;
            }
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        public bool Equals(FlightSchedule other)
        {
            if (this.FlightNumber == other.FlightNumber 
                && this.OriginCode == other.OriginCode 
                && this.DepartureTime == other.DepartureTime
                && this.getSumOfDaysOperating() == other.getSumOfDaysOperating())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            int hashFlightNum = this.FlightNumber == null ? 0 : this.FlightNumber.GetHashCode();
            int hashDepartureTime = this.DepartureTime.GetHashCode();
            int hashOriginCode = this.OriginCode == null ? 0 : this.OriginCode.GetHashCode();            
            int hashDaysOperating = this.getSumOfDaysOperating();

            return hashFlightNum ^ hashDepartureTime ^ hashOriginCode ^ hashDaysOperating;
        }

        /// <summary>
        /// this is actually only for equality/gethashcode part
        /// </summary>
        /// <returns></returns>
        private int getSumOfDaysOperating()
        {
            return this.DaysOperating.Sum(d => (int)d);
        }
    }
}
