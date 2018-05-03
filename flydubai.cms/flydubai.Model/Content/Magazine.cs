using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Magazine
    /// </summary>
    public class Magazine : EntityBase<Magazine, MagazineVersion>
    {
        public int MagazineId { get; set; }

        public override int Id
        {
            get { return this.MagazineId; }
            set { this.MagazineId = value; }
        }
    }
}
