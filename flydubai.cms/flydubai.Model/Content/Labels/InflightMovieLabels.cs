using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Inflight Entertainment Labels
    /// </summary>
    [DisplayName("Inflight entertainment labels")]
    public class InflightEntertainmentLabels : LabelsBase
    {
        [Key]
        public int InflightEntertainmentLabelsId { get; set; }

#region HeaderLabels

        [DefaultValue("Inflight Entertainment")]
        [DisplayName("Heading")]
        public string InflightEntertainmentHeading { get; set; }

        [DefaultValue("We keep out inflight entertainment fresh by updating every month.")]
        [DisplayName("Summary")]
        public string InflightEntertainmentSummary { get; set; }

#endregion HeaderLabels

#region TabLabels

        [DefaultValue("Pay Movies This Month")]
        [DisplayName("Pay Movies This Month Tab")]
        public string PayMoviesThisMonthTab { get; set; }

        [DefaultValue("Pay Movies Next Month")]
        [DisplayName("Pay Movies Next Month Tab")]
        public string PayMoviesNextMonthTab { get; set; }

        [DefaultValue("Pay TV")]
        [DisplayName("Pay TV Tab")]
        public string PayTvTab { get; set; }

        [DefaultValue("Free Music")]
        [DisplayName("Music Tab")]
        public string MusicTab { get; set; }

        [DefaultValue("Free Games")]
        [DisplayName("Games Tab")]
        public string GamesTab { get; set; }

        [DefaultValue("Buy Food and Drink")]
        [DisplayName("Food and Drink Tab")]
        public string FoodAndDrinkTab { get; set; }

        [DefaultValue("Buy Duty Free")]
        [DisplayName("Duty Free Tab")]
        public string DutyFreeTab { get; set; }

        [DefaultValue("Buy News Paper")]
        [DisplayName("News Paper Tab")]
        public string NewsPaperTab { get; set; }

#endregion TabLabels

#region ColumnHeaders

        [DefaultValue("Movie")]
        [DisplayName("Movie Title Column Header")]
        public string MovieTitleColumnHeader { get; set; }

        [DefaultValue("Genre")]
        [DisplayName("Movie Genre Column Header")]
        public string MovieGenreColumnHeader { get; set; }

        [DefaultValue("Cast")]
        [DisplayName("Movie Cast Column Header")]
        public string MovieCastColumnHeader { get; set; }

        [DefaultValue("Running Time")]
        [DisplayName("Movie Running Time Column Header")]
        public string MovieRunningTimeColumnHeader { get; set; }

        [DefaultValue("Trailer")]
        [DisplayName("Movie Trailer Column Header")]
        public string MovieTrailerColumnHeader { get; set; }

        [DefaultValue("Fee")]
        [DisplayName("Movie Fee Column Header")]
        public string MovieFeeColumnHeader { get; set; }
        
#endregion ColumnHeaders

#region SummaryLabels

        [DefaultValue("Rating")]
        [DisplayName("Rating text")]
        public string Rating { get; set; }

        [DefaultValue("Directed by")]
        [DisplayName("Director text")]
        public string Director { get; set; }

        [DefaultValue("Language")]
        [DisplayName("Language text")]
        public string MovieLanguage { get; set; }

        [DefaultValue("Cast")]
        [DisplayName("Cast text")]
        public string Cast { get; set; }
        
        [DefaultValue("Year")]
        [DisplayName("Year text")]
        public string Year { get; set; }

        [DefaultValue("Genre")]
        [DisplayName("Genre text")]
        public string Genre { get; set; }

        [DefaultValue("Synopsis")]
        [DisplayName("Synopsis text")]
        public string Synopsis { get; set; }

#endregion SummaryLabels

#region ListResultFormatting

        [DefaultValue("No movies")]
        [DisplayName("No movies text")]
        public string NoMoviesText { get; set; }

        [DefaultValue("{0} mins")]
        [DisplayName("Running time display format in minutes (example '{0} mins' or '{0} minutes)")]
        public string MovieRunningTimeInMinutes { get; set; }

        [DefaultValue("Watch Trailer")]
        [DisplayName("Watch Trailer text")]
        public string WatchTrailer { get; set; }

        [DefaultValue("No results found")]
        [DisplayName("No results text")]
        public string NoResultsText { get; set; }

#endregion ListResultFormatting

        [DefaultValue("AED")]
        public string PayMoviesCurrency { get; set; }

        [DefaultValue("In-flight entertainment (Movies showing this month)")]
        public string MoviesThisMonth { get; set; }

       
    }
}
