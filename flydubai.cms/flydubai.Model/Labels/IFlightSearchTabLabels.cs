using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Labels
{
    /// <summary>
    /// Interface of FlightSearchTabLabels
    /// </summary>
    public interface IFlightSearchTabLabels
    {
        string ReturnOneWayAccessibilityText { get; set; }

        string ReturnRadioButtonText { get; set; }

        string OneWayRadioButtonText { get; set; }

        string FlyingFromFlyingToAccessibilityText { get; set; }

        string FlyingFromLabelText { get; set; }

        string FlyingFromPlaceholderText { get; set; }

        string FlyingToLabelText { get; set; }

        string FlyingToPlaceholderText { get; set; }

        string AddMultipleDestinationsButton { get; set; }

        string FlyingDatesAccessibilityText { get; set; }

        string FlyingOutOnLabelText { get; set; }

        string FlyingBackOnLabelText { get; set; }

        string FlexibleOnDatesCheckboxText { get; set; }

        string PassengersAccessibilityText { get; set; }

        string PassengersLabelText { get; set; }

        string AdultsLabelText { get; set; }

        string AdultsAgeLabelText { get; set; }

        string ChildrenLabelText { get; set; }

        string ChildrenAgeLabelText { get; set; }

        string InfantsLabelText { get; set; }

        string InfantsAgeLabelText { get; set; }

        string InfantsTooltipHeadingText { get; set; }

        string InfantsTooltipBodyText { get; set; }

        string GroupBookingsLinkText { get; set; }

        string GroupBookingsTooltipHeadingText { get; set; }

        string GroupBookingsTooltipBodyText { get; set; }

        string GroupBookingsTooltipTelephoneText { get; set; }

        string GroupBookingsTooltipEmailText { get; set; }

        string GroupBookingsTooltipEmailAddress { get; set; }

        string PromoCodeAccessibilityText { get; set; }

        string PromoCodeLabelText { get; set; }

        string PromoCodePlaceholderText { get; set; }

        string PromoCodeTooltipHeadingText { get; set; }

        string PromoCodeTooltipBodyText { get; set; }

        string SubmitDetailsAccessibilityText { get; set; }

        string ShowFlightsButton { get; set; }

        string SeeFaqsText { get; set; }

        string SeeFaqsLinkText { get; set; }

        string SeeFaqsLinkUrl { get; set; }

        string MultiCity { get; set; }
    }
}
