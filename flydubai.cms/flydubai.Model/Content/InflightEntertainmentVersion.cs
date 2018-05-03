namespace flydubai.Model.Content
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Inflight Entertainment Version
    /// </summary>
    public class InflightEntertainmentVersion : EntityVersionBase<InflightEntertainment, InflightEntertainmentVersion>, IInflightEntertainment
    {
        [Key]
        public int InflightEntertainmentVersionId { get; set; }

        public override int Id
        {
            get
            {
                return this.InflightEntertainmentVersionId;
            }

            set
            {
                this.InflightEntertainmentVersionId = value;
            }
        }

        [Required]
        public string Name { get; set; }

        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string ExternalLinkUrl { get; set; }

        public int? Image { get; set; }

        public virtual InflightEntertainmentTypeWrapper EntertainmentType { get; set; }
    }
}