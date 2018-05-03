using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Fare Type Labels
    /// </summary>
    public class FareTypeLabels : LabelsBase
    {
        [Key]
        public int FareTypeLabelsId { get; set; }

        [DefaultValue("No Change")]
        public string FareType1Name { get; set; }

        [DefaultValue("Pay to change")]
        public string FareType2Name { get; set; }

        [DefaultValue("Free to change")]
        public string FareType3Name { get; set; }

        //Ibs Faretype a5466
        [DefaultValue("Business")]
        public string FareType4Name { get; set; }

        [DefaultValue("No Fee")]
        public string FareType1FeeText { get; set; }

        [DefaultValue("AED 50 extra per person")]
        public string FareType2FeeText { get; set; }

        [DefaultValue("AED 350 extra per person")]
        public string FareType3FeeText { get; set; }

        //Ibs Faretype a5466
        [DefaultValue("Business extra")]
        public string FareType4FeeText { get; set; }
    }
}