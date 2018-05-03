using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Inflight Movie Version
    /// </summary>
    public class InflightMovieVersion : EntityVersionBase<InflightMovie, InflightMovieVersion>, IInflightEntertainment
    {
        [Key]
        public int InflightMovieVersionId { get; set; }

        public override int Id
        {
            get { return this.InflightMovieVersionId; }
            set { this.InflightMovieVersionId = value; }
        }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string Cast { get; set; }

        /// <summary>
        /// Running Time in Minutes
        /// </summary>
        public int RunningTime { get; set; }

        public string TrailerUrl { get; set; }

        public decimal Fee { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }

        public string Director { get; set; }

        public int Year { get; set; }

        public string Rating { get; set; }

        public string Language { get; set; }

        public string Synopsis { get; set; }

        public bool? IsNewMovie { get; set; }

        public int? NewMovieSortOrder { get; set; }

        public int? Image { get; set; }

        public string ImagePath { get; set; }

        public InflightEntertainmentTypeWrapper EntertainmentType
        {
            get
            {
                return InflightEntertainmentType.PayMovies;
            }
        }
    }
}
