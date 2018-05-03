namespace flydubai.Model.Content
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Describes the information necessary to display specific messages depending on the route searched by the user
    /// </summary>
    public class RouteMessage : EntityBase<RouteMessage, RouteMessageVersion>
    {
        /// <summary>
        /// Gets or sets the route message id.
        /// </summary>
        /// <value>
        /// The route message id.
        /// </value>
        [Key]
        public int RouteMessageId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public override int Id
        {
            get { return this.RouteMessageId; }
            set { this.RouteMessageId = value; }
        }
    }
}
