using System;
namespace flydubai.Model.ReAccommodation
{
    [Serializable]
    public class ReaccomOptionalExtras
    {
        public int PersonOrgId { get; set; }

        public int CodeTypeCategoryId { get; set; }

        public int BaggageWeight { get; set; }

        public string SeatNumber { get; set; }

        public string MealCode { get; set; }

        public string IFECode { get; set; }

        public int PhysicalFlightId { get; set; }
    }
}
