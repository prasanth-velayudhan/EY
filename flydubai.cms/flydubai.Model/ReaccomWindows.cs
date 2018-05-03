namespace flydubai.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;

    /// <summary>
    /// Code Type
    /// </summary>
    [Serializable]
    public class ReaccomWindows
    {
        [Key]
        public int ReaccomWindowsId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string Origin { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string Destination { get; set; }

        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "{0} must be a Number.")]
        public int ReaccomWindow { get; set; }
    }
}
