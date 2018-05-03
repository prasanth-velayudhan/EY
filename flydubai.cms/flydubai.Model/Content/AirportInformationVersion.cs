using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Airport Information Version
    /// </summary>
    public class AirportInformationVersion : EntityVersionBase<AirportInformation, AirportInformationVersion>
    {
        [Key]
        public int AirportInformationId { get; set; }

        public override int Id
        {
            get { return this.AirportInformationId; }
            set { this.AirportInformationId = value; }
        }

        public string LocationDescription { get; set; }

        public string TimeZoneDescription { get; set; }

        public string Contacts { get; set; }

        public string TransferCity { get; set; }

        public string CarRental { get; set; }

        public string CarParking { get; set; }

        public string AirportFacilities { get; set; }

        public string VisaInformation { get; set; }

        public string CheckInInformation { get; set; }

        public string PageTitle { get; set; }

        public string Keywords { get; set; }

        public string Description { get; set; }
    }
}
