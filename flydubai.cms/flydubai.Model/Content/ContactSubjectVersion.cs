namespace flydubai.Model.Content
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Contact Subject Version
    /// </summary>
    public class ContactSubjectVersion : EntityVersionBase<ContactSubject, ContactSubjectVersion>
    {
        [Key]
        public int ContactSubjectVersionId { get; set; }

        public override int Id
        {
            get { return ContactSubjectVersionId; }
            set { ContactSubjectVersionId = value; }
        }

        [Required]
        public string Subject { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string RecipientEmail { get; set; }
    }
}