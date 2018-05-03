namespace flydubai.Model
{
    using System;

    /// <summary>
    /// Code Type Localised
    /// </summary>
    [Serializable]
    public class CodeTypeLocalised : ILocalisable
    {
        public int CodeTypeLocalisedId { get; set; }

        public string Language { get; set; }

        public string Name { get; set; }

        public virtual CodeType CodeType { get; set; }

        public int? ImageID { get; set; }

        public string ImageUrl { get; set; }

        public int Status { get; set; }
    }
}