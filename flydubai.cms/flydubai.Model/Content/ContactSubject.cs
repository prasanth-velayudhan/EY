namespace flydubai.Model.Content
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Contact Subject
    /// </summary>
    public class ContactSubject : EntityBase<ContactSubject, ContactSubjectVersion>
    {
        [Key]
        public int ContactSubjectId { get; set; }  

        public override int Id 
        {
            get { return ContactSubjectId; }
            set { ContactSubjectId = value; }
        }
    }
}
