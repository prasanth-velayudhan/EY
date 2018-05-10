using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Model.Common
{
    /// <summary>
    /// flight leg
    /// </summary>
    [Serializable]
    public class Leg
    {
        public int LFID { get; set; }
        public int PFID { get; set; }

        public string TempPFID { get; set; }

        public DateTime DepartureDate
        {
            get;
            set;
        }

        public string DepartureTime
        {
            get
            {
                return this.DepartureDate.ToString("HH:mm");
            }
        }

        public DateTime ArrivalDate { get; set; }

        public string ArrivalTime
        {
            get
            {
                return this.ArrivalDate.ToString("HH:mm");
            }
        }

        public int FlightTime { get; set; }

        public string FlightNum { get; set; }

        private string operatingCarrier;

        public string OperatingCarrier { get; set; }
        
        public string MarketingCarrier { get; set; }

        public string MarketingFlightNum { get; set; }
        public string Origin { get; set; }

        public string Destination { get; set; }

        public string FromTerminal { get; set; }

        public string ToTerminal { get; set; }

        public string FlightNumWithCarrier
        {
            get
            {
                return string.Format("{0} {1}", this.OperatingCarrier, this.FlightNum);
            }
        }

        public Leg ShallowCopy()
        {
            return (Leg)this.MemberwiseClone();
        }
        public string AvailableMealInventoryMstrCode { get; set; }

        public bool IsWithinCutoffPeriod { get; set; }

        public BookingCode BookingCodes { get; set; }
        
        public string EquipmentType { get; set; }
    }

    public class BookingCode
    {
        public string cabin { get; set; }
        public string fareClass { get; set; }
        public List<string> paxID { get; set; }
    }
}
