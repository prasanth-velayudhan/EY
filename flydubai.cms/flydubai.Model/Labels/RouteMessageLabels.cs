using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace flydubai.Model.Labels
{
    public class RouteMessageLabels : BaseLabels
    {
        public string Title { get; set; }

        public string AcceptButton { get; set; }

        public string CancelButton { get; set; }

        public string RestrictionsHeading { get; set; }

        public string ReadAndUnderstand { get; set; }

        public string RouteLabel { get; set; }

        public string DateLabel { get; set; }

        public string FlightNumLabel { get; set; }

        public string DaysAffectedLabel { get; set; }

        public string MondayName { get; set; }

        public string TuesdayName { get; set; }

        public string WednesdayaName { get; set; }

        public string ThursdayName { get; set; }

        public string FridayName { get; set; }

        public string SaturdayName { get; set; }

        public string SundayName { get; set; }

        [DisplayName("[TA] Non Combinable Message Title")]
        public string NonCombinableMessageMessageTitle { get; set; }

    }
}
