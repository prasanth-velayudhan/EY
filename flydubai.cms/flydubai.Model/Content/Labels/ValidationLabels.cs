using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Validation Labels
    /// </summary>
    [DisplayName("Validation Labels (applies to all content site)")]
    public class ValidationLabels : LabelsBase
    {
        [Key]
        public int ValidationLabelsId { get; set; }

        [DefaultValue("Please enter a value for this field.")]
        public string DefaultRequired { get; set; }

        [DefaultValue("Please only use lowercase alphanumeric characters and hyphens.")]
        public string DefaultLowerCaseAlphaNumeric { get; set; }

        [DefaultValue("The flight path is not valid.")]
        public string InvalidFlightRoute { get; set; }

        [DefaultValue("The flight number is not valid.")]
        public string InvalidFlightNumber { get; set; }

        [DefaultValue("The phone number is not valid.")]
        public string InvalidPhoneNumber { get; set; }

        [DefaultValue("The email address is not valid.")]
        public string InvalidEmail { get; set; }

        [DefaultValue("Invalid value.")]
        public string InvalidValue { get; set; }

        [DefaultValue("Please select atleast one destination.")]
        public string AtleastOneDestinationRequired { get; set; }

        [DefaultValue("Please select atleast one subscription.")]
        public string AtleastOneSubscriptionRequired { get; set; }
    }
}
