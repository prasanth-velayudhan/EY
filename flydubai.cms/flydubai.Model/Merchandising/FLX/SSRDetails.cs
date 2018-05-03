using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using flydubai.Common;

namespace flydubai.Model.Merchandising.FLX
{
    public class SSRDetails
    {
        public Enums.SeatSSRCode SeatSSRCode { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public bool IsAmountActive { get; set; }
        public string CategoryId { get; set; }
        public string SSRCode { get; set; }
        public bool IsRefundable { get; set; }
        public bool IsServiceActive { get; set; }
        public int MaxCountAvailable { get; set; }
        public int QuantityAvailable { get; set; }
        public string SSRCurrencyCode { get; set; }

    }
}
