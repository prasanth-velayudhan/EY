namespace flydubai.Model.Booking
{
	using System;
	using System.Collections.Generic;
    using System.Linq;

    using flydubai.Model.Payment;

    /// <summary>
    /// Passenger Name Record
    /// </summary>
	[Serializable]
	public class PassengerNameRecord
	{
        public PassengerNameRecord()
		{
			this.LogicalFlights = new List<LogicalFlight>();
			this.Payments = new List<Payment>();
			this.ContactInfos = new List<ContactInfo>();
            this.bckupVoucherPaymentDetailsList = new List<VoucherPaymentDetails>();
		}

		public string Key { get; set; }

        public long PNRPin { get; set; }

		public string ConfirmationNumber { get; set; }

		public string IataNumber { get; set; }

		public bool BalancedReservation { get; set; }

		public string ReservationCurrency { get; set; }

		public DateTime BookDate { get; set; }

        public DateTime LastModified { get; set; }

        public decimal ReservationBalance { get; set; }//amount due(including tfee),available credit

        public decimal ReservationBalanceForDisplayInPaymentPage { get; set; }

        public decimal ReservationBalanceNoDiscount { get; set; }

        public string BookingAgent { get; set; }

        public string Cabin { get; set; }//Added by a-5467 - Platinum changes

		private List<LogicalFlight> _logicalFlights;

		public string SeriesNumber { get; set; }

		public string AirlineKey { get; set; }

        public bool IsInterline { get; set; }

        public bool IsCodeShare { get; set; }

		public List<LogicalFlight> LogicalFlights
		{
			get { return _logicalFlights; }
			set { _logicalFlights = (value == null ? null : value.OrderBy(l => l.DepartureDate).ToList()); }
		}

        /// <summary>
        /// Gets the active logical flight.
        /// </summary>
        /// <param name="lfid">The lfid.</param>
        /// <param name="departureDate">The departure date.</param>
        /// <returns></returns>
        public LogicalFlight GetActiveLogicalFlight(int lfid, DateTime departureDate)
        {
            return this.LogicalFlights.Single(lf => lf.IsActive && lf.LogicalFlightId == lfid && lf.DepartureDate.Date == departureDate.Date);
        }

		public List<Payment> Payments { get; set; }

		public int NumDebitCreditCardFailedPayments { get; set; }

		public string PromotionalCode { get; set; }

		public decimal ChangeFee { get; set; }

		public List<ContactInfo> ContactInfos { get; set; }

        public DateTime ReservationFulfillmentRequiredByODT { get; set; }

        public DateTime ReservationFulfillmentRequiredByGMT { get; set; }

        public string ReservationType { get; set; }

		public decimal CreditCardFee
		{
			get
			{
				return this.AirlinePersons.Sum(a => a.ActiveCharges.Sum(c => c.CodeType == "PMNT"? c.Amount : 0));
			}
		}

        public decimal ActiveCreditCardFee
        {
            get
            {
                return this.AirlinePersons.Where(ap => ap.IsActive).Sum(a => a.ActiveCharges.Sum(c => c.CodeType == "PMNT" ? c.Amount : 0));
            }
        }

		public decimal PenaltyFee
		{
			get
			{
				return this.AirlinePersons.Sum(a => a.ActiveCharges.Sum(c => c.CodeType == "PNLT"? c.Amount : 0));
			}
		}

        /// <summary>
        /// Holds the TFEE
        /// </summary>
        public decimal TFEE
        {
            get
            {
                return this.AirlinePersons.Sum(a => a.ActiveCharges.Sum(c => c.CodeType == "TFEE" ? c.Amount : 0));
            }        
        
        }

        public decimal BFEE
        {
            get
            {
                return this.AirlinePersons.Sum(a => a.ActiveCharges.Sum(c => c.CodeType == "BFEE" ? c.Amount : 0));
            }

        }

        public decimal ActiveBFEE
        {
            get
            {
                return this.AirlinePersons.Where(ap => ap.IsActive).Sum(a => a.ActiveCharges.Sum(c => c.CodeType == "BFEE" ? c.Amount : 0));
            }

        }

        

		public decimal NonRefundableInsuranceFee
		{
			get
			{
				return this.AirlinePersons.Sum(a => a.Charges.Sum(c => c.CodeType == "INSU" && c.ChargeStatus == 0? c.Amount : 0));
			}
		}

        /// <summary>
        /// Determines whether [has passenger with last name] [the specified last name].
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns>
        ///   <c>true</c> if [has passenger with last name] [the specified last name]; otherwise, <c>false</c>.
        /// </returns>
		public bool HasPassengerWithLastName(string lastName)
		{
			return this.AirlinePersons.Any(a => a.LastName.Trim().ToUpper() == lastName.Trim().ToUpper());
		}

		public int TotalPassengers
		{
			get
			{
                return this.LogicalFlights.Last(lf => lf.IsActive).PhysicalFlights.First().Customers.First().AirlinePersons.Count(ap => ap.IsActive);
			}
		}

		public IEnumerable<AirlinePerson> AirlinePersons
		{
			get
			{
				foreach (var logicalFlight in this.LogicalFlights)
				{
					foreach (var physicalFlight in logicalFlight.PhysicalFlights)
					{
						foreach (var customer in physicalFlight.Customers)
						{
							foreach (var airlinePerson in customer.AirlinePersons)
							{
								yield return airlinePerson;
							}
						}
					}
				}
			}
		}        

		public decimal JourneyTotal
		{
			get
			{
				return this.AirlinePersons.Where(ap => ap.IsActive).Sum(a => a.ActiveCharges.Sum(c => c.Amount)) + this.PenaltyFee + this.NonRefundableInsuranceFee;
			}
		}

        /// <summary>
        /// Ares the seats assigned.
        /// </summary>
        /// <param name="seatAssignments">The seat assignments.</param>
        /// <returns></returns>
		public bool AreSeatsAssigned(IEnumerable<SeatAssignment> seatAssignments)
		{
			foreach (var seatAssignment in seatAssignments)
			{
			    var airlinePerson = this.AirlinePersons.FirstOrDefault(a => a.IsActive && a.SeatAssignment.Key == seatAssignment.Key);

                if (airlinePerson == null)
                {
                    return false;
                }

                if ((airlinePerson.SeatAssignment.RowNumber == seatAssignment.RowNumber && airlinePerson.SeatAssignment.Seat.Trim() == seatAssignment.Seat.Trim()) == false)
				{
					return false;
				}
			}

			return true;
		}

        public MPesaPayment MPesaPayment { get; set; }
        public decimal PMNTafterRemove { get; set; }
        public decimal PMNTafterDiscountCall { get; set; }

        [Serializable]
        public class ProcessPayment
        {
            public PassengerNameRecord PassengerNameRecord { get; set; }
            public flydubai.Model.BookingMW.ProcessPaymentResponse ProcessPaymentResponse { get; set; }
        }

        public List<VoucherPaymentDetails> bckupVoucherPaymentDetailsList { get; set; }

        public Nullable<flydubai.Common.Enums.PNRValidStatus> PNRValidStatus { get; set; }

        public string OAConfirmationNumbers { get; set; }

        public IEnumerable<AirlinePerson> AirlinePersonsActive(List<String> logicalFlightKeys)
        {
            foreach (var logicalFlight in this.LogicalFlights)
            {
                if (logicalFlightKeys.Contains(logicalFlight.Key))
                {

                    foreach (var physicalFlight in logicalFlight.PhysicalFlights)
                    {
                        foreach (var customer in physicalFlight.Customers)
                        {
                            foreach (var airlinePerson in customer.AirlinePersons)
                            {
                                yield return airlinePerson;
                            }
                        }
                    }
                }
            }
        }
       
	}
}
