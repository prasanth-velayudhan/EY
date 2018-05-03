using System.ComponentModel.DataAnnotations;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Global PR Contact Version
    /// </summary>
    public class GlobalPRContactVersion : EntityVersionBase<GlobalPRContact, GlobalPRContactVersion>
    {
        public int GlobalPRContactVersionId { get; set; }
        public override int Id
        {
            get { return GlobalPRContactVersionId; }
            set { GlobalPRContactVersionId = value; }
        }
        
        [Required]
        public string Location { get; set; }

        //[Required]
        public string Email { get; set; }

        //[Required]
        public string Telephone { get; set; }

        public string TelephoneContactHours { get; set; }

        [Required]
        public string ContactName { get; set; }

        [Required]
        public string ContactDetails { get; set; }


        public string Designation { get; set; }
    }
}