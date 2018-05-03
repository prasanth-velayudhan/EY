using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Global PR Contact Labels
    /// </summary>
    [DisplayName("Global PR Contact labels")]
    public class GlobalPRContactLabels : LabelsBase
    {
        [Key]
        public int GlobalPRContactLabelsId { get; set; }

        [DefaultValue("Offices")]
        [DisplayName("List Section Header")]
        public string ListSectionHeader { get; set; }

        [DefaultValue("Search")]
        [DisplayName("Search Section Header")]
        public string SearchSectionHeader { get; set; }

        [DefaultValue("Country")]
        [DisplayName("Search Country Label Text")]
        public string SearchCountryLabelText { get; set; }

        [DefaultValue("Search")]
        [DisplayName("Search button label")]
        public string SearchButtonLabel { get; set; }

        [DefaultValue("- Select Country -")]
        [DisplayName("Country Dropdown list default option")]
        public string CountryDropdownDefaultOption { get; set; }

        [DefaultValue("Location")]
        [DisplayName("Location Column Header")]
        public string LocationColumnHeader { get; set; }

        [DefaultValue("Email")]
        [DisplayName("Email Column Header")]
        public string EmailColumnHeader { get; set; }

        [DefaultValue("Telephone")]
        [DisplayName("Telephone Column Header")]
        public string TelephoneColumnHeader { get; set; }

        [DefaultValue("Contact Name")]
        [DisplayName("Contact Name Column Header")]
        public string ContactName { get; set; }
    }
}
