namespace flydubai.Model.Content.Labels
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Car Hire Labels
    /// </summary>
    public class CarHireLabels : LabelsBase
    {
        [Key]
        public int CarHireLabelsId { get; set; }

        [DefaultValue("Car Rental")]
        [DisplayName("Car rental title")]
        public string CarRental { get; set; }

        [DefaultValue("Car Hire")]
        [DisplayName("Car hire button text")]
        public string CarHire { get; set; }
    }
}
