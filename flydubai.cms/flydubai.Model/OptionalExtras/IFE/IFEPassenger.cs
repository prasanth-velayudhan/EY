namespace flydubai.Model.OptionalExtras.IFE
{
    using System.Collections.Generic;
    using System.Linq;

    using flydubai.Common;
    using System;

    /// <summary>
    /// IFE Passenger
    /// </summary>
    public class IFEPassenger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IFEPassenger"/> class.
        /// </summary>
        public IFEPassenger()
        {
            this.IFEsPerFlight = new List<IFEPassengerFlight>();
        }

        public string PassengerName { get; set; }

        //public bool PossibleIFE { get; set; }

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

        public List<IFEPassengerFlight> IFEsPerFlight { get; set; }

        public bool HaveAllFlightsSameIFE
        {
            get
            {
                if (this.IFEsPerFlight.Count() == 1)
                    return false;

                var firstIFE = this.IFEsPerFlight.First();

                foreach (var IFE in this.IFEsPerFlight)
                {
                    if (IFE.IFEPrices.Count() != firstIFE.IFEPrices.Count())
                    {
                        return false;
                    }

                    for (int i = 0; i < IFE.IFEPrices.Count(); i++)
                    {
                        if (firstIFE.IFEPrices[i].Equals(IFE.IFEPrices[i]) == false)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }

        public bool CanHaveOwnIFE
        {
            get
            {
                return this.PassengerType != Enums.PassengerTypes.Infant;
            }
        }
    }
}