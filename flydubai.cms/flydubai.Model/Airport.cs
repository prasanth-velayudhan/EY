using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using flydubai.Model.Content;

namespace flydubai.Model
{
    /// <summary>
    /// Airport
    /// </summary>
    [Serializable]
    public class Airport
    {
        TimeSpan? _utcOffset;

        [Key]
        [MaxLength(3)]
        [Required]
        public string AirportCode { get; set; }

        public double? Lat { get; set; }

        public double? Long { get; set; }

        [MaxLength(3)]
        public string CurrencyCode { get; set; }

        public virtual ICollection<AirportLocalised> Localised { get; set; }

        public virtual ICollection<AirportDestination> Destinations { get; set; }

        [NotMapped]
        public int? DestinationGuideId
        {
            get { return this.CurrentLocale().DestinationGuideId; }
            set { this.CurrentLocale().DestinationGuideId = value; }
        }

        [NotMapped]
        public virtual DestinationGuide DestinationGuide
        {
            get { return this.CurrentLocale().DestinationGuide; }
        }

        [Obsolete("Use GetUtcOffset().  This should only be used for Radixx service calls and data population.")]
        public string OffsetFromGMT { get; set; }

        /// <summary>
        /// Gets the TimeSpan equivalent of the OffsetFromGMT string value.
        /// </summary>
        public TimeSpan GetUtcOffset()
        {
            if (!this._utcOffset.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(this.OffsetFromGMT))
                {
                    try
                    {
                        bool isNegative = this.OffsetFromGMT.StartsWith("-");
                        this._utcOffset = TimeSpan.ParseExact(this.OffsetFromGMT, new string[] { @"\+%h\:%m", @"\-%h\:%m", @"%h\:%m" }, CultureInfo.InvariantCulture, isNegative ? TimeSpanStyles.AssumeNegative : TimeSpanStyles.None);
                    }
                    catch (FormatException ex)
                    {
                        throw new Exception(string.Format("The airport '{0}' has an invalid GMT offset '{1}' and should be in the format +02:00 for example.  Please contact the system administrator.", this.AirportCode, this.OffsetFromGMT), ex);
                    }
                }
                else
                {
                    this._utcOffset = TimeSpan.FromHours(0);
                }
            }

            return this._utcOffset.Value;
        }

        public virtual Country Country { get; set; }

        public bool AdvancedPassengerInfoRequired { get; set; }

        //WR4 FR013 A-5851 : Start
        [ForeignKey("Country")]
        public virtual int Country_CountryId { get; set; }
        //WR4 FR013 A-5851 : End

        public bool Active { get; set; }
        //IBS - Metro Search
        public string MetroCode { get; set; }

        public bool MetroActive { get; set; }

        //IBS A-5446 WR5 WR-40 :Start
        public bool isActive { get; set; }
        //IBS A-5446 WR5 WR-40 :End

        public bool IsBusRoute { get; set; }

        public bool IsDisplay { get; set; }
    }
}
