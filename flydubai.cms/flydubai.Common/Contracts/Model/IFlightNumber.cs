using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common.Contracts.Model
{
    /// <summary>
    /// FlightNumber Interface
    /// </summary>
    public interface IFlightNumber
    {
        string CarrierCode { get; }

        string Number { get; set; }

        bool IsValid { get; }
    }
}
