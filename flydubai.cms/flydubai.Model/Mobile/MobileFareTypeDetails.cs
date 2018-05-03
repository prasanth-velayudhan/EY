using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Model.Content;

namespace flydubai.Model.Mobile
{
    /// <summary>
    /// Mobile Fare Type 
    /// </summary>
    public class MobileFareTypeDetails
    {
        /// <summary>
        /// Gets or sets the fare type labels, an instance of <see cref="FareType"/> 
        /// </summary>
        /// <value>The fare type labels.</value>
        public IEnumerable<FareType> FareTypeDescriptionLabels { get; set; }
        /// <summary>
        /// Gets or sets the fares, a List of <see cref="ResultFare"/> 
        /// </summary>
        /// <value>The fares.</value>
        public List<ResultFare> Fares { get; set; }

        /// <summary>
        /// Gets or sets the fare type labels, an instance of <see cref="MobileFareTypeLabels"/> 
        /// </summary>
        /// <value>The fare type labels.</value>
        /// 
        public MobileFareTypeLabels FareTypeLabels { get; set; }
    }

    public class ResultFare
    {
        /// <summary>
        /// Gets or sets the lfid, an instance of <see cref="System.Int32"/> 
        /// </summary>
        /// <value>The lfid.</value>
        public int Lfid { get; set; }
        /// <summary>
        /// Gets or sets the departure time, an instance of <see cref="DateTime"/> 
        /// </summary>
        /// <value>The departure time.</value>
        public DateTime DepartureTime { get; set; }
        /// <summary>
        /// Gets or sets the arrival time, an instance of <see cref="DateTime"/> 
        /// </summary>
        /// <value>The arrival time.</value>
        public DateTime ArrivalTime { get; set; }
        /// <summary>
        /// Gets or sets the duration, an instance of <see cref="TimeSpan"/> 
        /// </summary>
        /// <value>The duration.</value>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Gets or sets the waiting times, a collection of <see cref="TimeSpan"/> 
        /// </summary>
        /// <value>The waiting times.</value>
        public List<TimeSpan> WaitingTimes { get; set; }
        /// <summary>
        /// Gets or sets the stops, an instance of <see cref="System.Int32"/> 
        /// </summary>
        /// <value>The stops.</value>
        public int Stops { get; set; }


        public int SolutionID { get; set; }
        public bool CMPFare { get; set; }

        /// <summary>
        /// Gets or sets the fare id, an instance of <see cref="System.Int32"/> 
        /// </summary>
        /// <value>The fare id.</value>
        public int FareId { get; set; }
        /// <summary>
        /// Gets or sets the fare amount, an instance of <see cref="System.Decimal"/> 
        /// </summary>
        /// <value>The fare amount.</value>
        public decimal FareAmount { get; set; }
        /// <summary>
        /// Gets or sets the type of the fare., an instance of <see cref="System.String"/> 
        /// </summary>
        /// <value>The type of the fare.</value>
        public string FareType { get; set; }
        /// <summary>
        /// Gets or sets the fare type id, an instance of <see cref="System.Int32"/> 
        /// </summary>
        /// <value>The fare type id.</value>
        public int FareTypeId { get; set; }
        /// <summary>
        /// Gets or sets the seats available, an instance of <see cref="System.Int32"/> 
        /// </summary>
        /// <value>The seats available.</value>
        public int SeatsAvailable { get; set; }

        /// <summary>
        /// Gets or sets the flight numbers, a List of <see cref="System.String"/> 
        /// </summary>
        /// <value>The flight numbers.</value>
        public List<string> FlightNumbers { get; set; }
        /// <summary>
        /// Gets or sets the stop airports, an instance of <see cref="System.String"/> 
        /// </summary>
        /// <value>The stop airports.</value>
        public string StopAirports { get; set; }

        /// <summary>
        /// Returns a formatted duration text description
        /// </summary>
        /// <returns><see cref="System.String" /></returns>
        public string GetDurationText()
        {
            return string.Format("{0}h {1}m", ((Duration.Days * 24) + Duration.Hours), Duration.Minutes);
        }

        /// <summary>
        /// Gets the flattened flight numbers, an instance of <see cref="System.String"/> 
        /// </summary>
        /// <value>The flattened flight numbers.</value>
        public string FlattenedFlightNumbers
        {
            get { return string.Join(" / ", this.FlightNumbers); }
        }

        /// <summary>
        /// Gets the flight identifier based on Lfid and FareId
        /// </summary>
        /// <returns><see cref="System.String" /></returns>
        public string GetFlightIdentifier()
        {
            return GetFlightIdentifier(this.Lfid, this.FareId, this.SolutionID);
        }

        /// <summary>
        /// Gets the flight identifier based on parameters Lfid and FareId 
        /// </summary>
        /// <param name="lfid">An instance of <see cref="System.Int32" /></param>
        /// <param name="fareId">An instance of <see cref="System.Int32" /></param>
        /// <returns><see cref="System.String" /></returns>
        public static string GetFlightIdentifier(int lfid, int fareId, int solutionId)
        {
            return string.Format("flight_{0}_{1}_{2}", lfid, fareId, solutionId);
        }

        /// <summary>
        /// Gets the total waiting time, an instance of <see cref="TimeSpan"/> 
        /// </summary>
        /// <value>The total waiting time.</value>
        public TimeSpan TotalWaitingTime
        {
            get
            {
                TimeSpan totalWaitTime = new TimeSpan(0, 0, 0);
                if (this.WaitingTimes != null && this.WaitingTimes.Count > 0)
                {
                    foreach (TimeSpan waitTime in this.WaitingTimes)
                    {
                        totalWaitTime = totalWaitTime.Add(waitTime);
                    }
                }
                return totalWaitTime;
            }
        }
        //IBS MAC metro search
        public string OriginLabel { get; set; }
        public string DestinationLabel { get; set; }


    }
}
