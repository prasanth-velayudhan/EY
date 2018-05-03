using flydubai.Model.Results;
using flydubai.Common;

namespace flydubai.Model.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Flight
    /// </summary>
    [Serializable]
    public class Flight : ILocalTravelContext
    {
        public Flight()
        {
            this.Legs = new List<Leg>();
            this.FlightFares = new List<FlightFare>();
        }

        public int LFID { get; set; }

        public List<Leg> Legs { get; set; }

        public string Origin
        {
            get
            {
                return this.Legs.OrderBy(l => l.DepartureDate).First().Origin;
            }
        }

        //Added by a-5467 - Platinum changes
        public string AircraftType { get; set; }

        public DateTime DepartureDate
        {
            get
            {
                return this.Legs.OrderBy(l => l.DepartureDate).First().DepartureDate;
            }
        }

        public DateTime FZDepartureDate
        {
            get
            {
                if (this.Legs.Any(x => x.OperatingCarrier.ToUpper().Trim() == Constants.FlydubaiCarrierCode))
                {
                    return this.Legs.OrderBy(l => l.DepartureDate).FirstOrDefault(x => !x.IsOtherAirline).DepartureDate;
                }
                else
                {
                    return this.Legs.OrderBy(l => l.DepartureDate).FirstOrDefault().DepartureDate;
                }
            }
        }

        public string Destination
        {
            get
            {
                return this.Legs.OrderBy(l => l.DepartureDate).Last().Destination;
            }
        }

        public DateTime ArrivalDate
        {
            get
            {
                return this.Legs.OrderBy(l => l.DepartureDate).Last().ArrivalDate;
            }
        }

        public int NumOfStops
        {
            get
            {
                return this.Legs.Count - 1;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                TimeSpan duration = new TimeSpan();
                if (this.NumOfStops == 0)
                {
                    duration = new TimeSpan(0, this.Legs[0].FlightTime, 0);
                }
                else
                {
                    foreach (var leg in this.Legs)
                    {
                        duration = duration.Add(new TimeSpan(0, leg.FlightTime, 0));
                    }

                    foreach (var waitingTime in this.WaitingTimes)
                    {
                        duration = duration.Add(waitingTime);
                    }
                }

                return duration;
            }
        }

        public List<TimeSpan> WaitingTimes
        {
            get
            {
                if (this.NumOfStops == 0)
                {
                    return new List<TimeSpan>();
                }

                List<TimeSpan> waitingTimes = new List<TimeSpan>();
                for (int i = 1; i < this.Legs.Count; i++)
                {
                    waitingTimes.Add(this.Legs[i].DepartureDate - this.Legs[i - 1].ArrivalDate);
                }
                return waitingTimes;
            }
        }

        public List<FlightFare> FlightFares { get; set; }

        public bool IsSoldOut { get; set; }

        public string FlightNum { get; set; }

        //Interline changes
        public bool IsInterline
        {
            get
            {
                //return this.Legs.Any(l => !(l.MarketingCarrier == null || l.MarketingCarrier == Constants.FlydubaiCarrierCode));
                return this.Legs.Any(l => l.IsOtherAirline == true);
            }
        }

        public int TempLFID { get; set; }

        public string FlightGroupID { get; set; }

        public string OperatingCarrier { get; set; }
        public string SellingCarrier { get; set; }
        //multicity
        public bool IsMulticityMctValid { get; set; }
        public bool IsMulticityStopOverOrConnection
        {
            get
            {
                return this.FlightFares.Count > 0 && this.FlightFares.All(f => f.FareAmtNoTaxes <= 0);
            }
        }
    }
}
