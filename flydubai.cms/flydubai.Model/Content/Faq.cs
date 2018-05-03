using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Faq
    /// </summary>
    public class Faq : EntityBase<Faq, FaqVersion>
    {
        [Key]
        public int FaqId { get; set; }

        public override int Id
        {
            get { return this.FaqId; }
            set { this.FaqId = value; }
        }
    }
}
