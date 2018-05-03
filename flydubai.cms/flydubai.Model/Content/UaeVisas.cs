using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using flydubai.Model.Content;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Uae Visas
    /// </summary>
    public class UaeVisas : EntityBase<UaeVisas, UaeVisasVersion>
    {
        [Key]
        public int HowToApplyUaeVisasId { get; set; }

        public override int Id
        {
            get { return this.HowToApplyUaeVisasId; }
            set { this.HowToApplyUaeVisasId = value; }
        }
    }
}
