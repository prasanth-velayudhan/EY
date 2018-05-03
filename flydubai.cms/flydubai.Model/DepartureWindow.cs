namespace flydubai.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Departure Window
    /// </summary>
    [Serializable]
    public class DepartureWindow
    {
        public int DepartureWindowId { get; set; }

        public string Name { get; set; }

        public int Minutes { get; set; }
    }
}
