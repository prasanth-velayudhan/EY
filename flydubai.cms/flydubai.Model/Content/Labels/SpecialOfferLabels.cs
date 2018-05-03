using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Special Offer Labels
    /// </summary>
    public class SpecialOfferLabels : LabelsBase
    {
        [Key]
        public int SpecialOfferLabelsId { get; set; }

        [DefaultValue("Special offers")]
        public string ModuleTitle { get; set; }

        [DefaultValue("See all")]
        public string SeeAllLink { get; set; }

        [DefaultValue("Promo code")]
        public string PromoCode { get; set; }

        [DefaultValue("Book")]
        public string BookButtonText { get; set; }

        [DefaultValue("Use this code")]
        public string UseThisCodeButtonText { get; set; }

        [DefaultValue("Terms and conditions apply")]
        public string TermsAndConditionsLink { get; set; }

        [DefaultValue("Terms and conditions")]
        public string TermsAndConditionsHeading { get; set; }

        [DefaultValue("Free")]
        public string Free { get; set; }

        [DefaultValue("Search")]
        public string SearchTitle { get; set; }

        [DefaultValue("Flying from")]
        public string SearchFlyingFrom { get; set; }

        [DefaultValue("- Select -")]
        public string SearchFlyingFromSelect { get; set; }

        [DefaultValue("Order by")]
        public string SearchSortBy { get; set; }

        [DefaultValue("Sort by")]
        public string SearchAndSortBy { get; set; }

        [DefaultValue("Go")]
        public string SearchGo { get; set; }

        [DefaultValue("Page {0} of {1}")]
        [DisplayName("Paging text (use {0} for current page, {1} for total pages) (e.g. Page {0} of {1})")]
        public string SearchPaging { get; set; }

        [DefaultValue("Previous")]
        public string SearchPagingPrevious { get; set; }

        [DefaultValue("Next")]
        public string SearchPagingNext { get; set; }

        [DefaultValue("Time")]
        public string SearchSortTime { get; set; }

        [DefaultValue("Price")]
        public string SearchSortPrice { get; set; }

        [DefaultValue("Hotels")]
        public string SearchSortHotels { get; set; }

        [DefaultValue("Car Hire")]
        public string SearchSortCarHire { get; set; }

        [DefaultValue("Ending Soonest")]
        public string SearchSortEndingSoonest { get; set; }

        [DefaultValue("Newly Listed")]
        public string SearchSortNewlyListed { get; set; }

        [DefaultValue("Lowest First")]
        public string SearchSortLowestFirst { get; set; }

        [DefaultValue("Highest First")]
        public string SearchSortHighestFirst { get; set; }

        [DefaultValue("Price: Lowest First")]
        public string SearchSortPriceLowestFirst { get; set; }

        [DefaultValue("Price: Highest First")]
        public string SearchSortPriceHighestFirst { get; set; }

        [DefaultValue("Where are you flying from?")]
        public string TooltipHeading { get; set; }

        [DefaultValue("Select your departure airport from here.")]
        public string TooltipText { get; set; }
    }
}
