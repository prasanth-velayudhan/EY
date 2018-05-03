using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Inflight Movie
    /// </summary>
    public class InflightMovie : EntityBase<InflightMovie, InflightMovieVersion>
    {
        [Key]
        public int InflightMovieId { get; set; }

        public override int Id
        {
            get { return InflightMovieId; }
            set { InflightMovieId = value; }
        } 
    }
}
