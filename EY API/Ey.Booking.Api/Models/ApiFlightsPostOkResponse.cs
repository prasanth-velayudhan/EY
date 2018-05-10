using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ey.Booking.Api.Models
{
    public class ApiFlightsPostOkResponse
    {

        [Required]
        [JsonProperty("segments")]
        public IList<Segments> Segments { get; set; }        
    }
}