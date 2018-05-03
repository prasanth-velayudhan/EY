using System;
using System.Xml.Serialization;

namespace flydubai.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// abstract class Base Labels
    /// </summary>
    public abstract class BaseLabels
    {
        [Key]
        public string Language { get; set; }
    }
}
