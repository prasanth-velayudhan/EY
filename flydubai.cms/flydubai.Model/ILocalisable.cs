using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace flydubai.Model
{
    /// <summary>
    /// interface for Localisable
    /// </summary>
    public interface ILocalisable
    {
        string Language { get; set; }
    }
}
