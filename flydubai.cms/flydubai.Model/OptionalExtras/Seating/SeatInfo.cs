namespace flydubai.Model.OptionalExtras.Seating
{
    /// <summary>
    /// Seat Info
    /// </summary>
    public class SeatInfo
    {
        public string CodeType { get; set; }

        public int Row { get; set; }

        public string Seat { get; set; }

        public decimal Amount { get; set; }

        public bool IsAvailable { get; set; }

        public int PFID { get; set; }
    }
}