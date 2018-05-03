using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace flydubai.Model.OptionalExtras.SSR
{
    using flydubai.Common;
    public class TASpeceficPassenger
    {

        public TASpeceficPassenger()
        {
            this.TASSRPerFlight = new List<TASSRPassengerFlight>();
        }


        public string PassengerName { get; set; }

        public Enums.PassengerTypes PassengerType { get; set; }

        public int SortOrder
        {
            get
            {
                switch (PassengerType)
                {
                    case Enums.PassengerTypes.Adult:
                        return 1;
                    case Enums.PassengerTypes.Child:
                        return 2;
                    case Enums.PassengerTypes.Infant:
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException("PassengerType");
                }
            }
        }

        public int PassengerId { get; set; }

        public bool IsPrimaryPassenger { get; set; }

        public List<TASSRPassengerFlight> TASSRPerFlight { get; set; }

        public string CodeType { get; set; }

        public bool isSelected { get; set; }

        public bool CanHaveAssignedOwnTASSR
        {
            get
            {
                return this.PassengerType != Enums.PassengerTypes.Infant;
            }
        }

        public bool HaveAllFlightsSameTASSRAllowance
        {
            get
            {
                var firstTASSRAllowance = this.TASSRPerFlight.First();

                foreach (var tassrAllowance in this.TASSRPerFlight)
                {
                    if (tassrAllowance.TASSRAllowancePrices != firstTASSRAllowance.TASSRAllowancePrices)
                    {
                        return false;
                    }                    
                }

                return true;
            }
        }

    }
}
