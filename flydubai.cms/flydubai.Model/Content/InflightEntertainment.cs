namespace flydubai.Model.Content
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Inflight Entertainment
    /// </summary>
    public class InflightEntertainment : EntityBase<InflightEntertainment, InflightEntertainmentVersion>
    {
        [Key]
        public int InflightEntertainmentId { get; set; }

        public override int Id
        {
            get
            {
                return this.InflightEntertainmentId;
            }

            set
            {
                this.InflightEntertainmentId = value;
            }
        }
    }
}
