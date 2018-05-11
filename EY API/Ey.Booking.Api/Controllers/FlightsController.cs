using Ey.Booking.Api.Models;
using Ey.Business;
using Ey.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ey.Booking.Api.Controllers
{
    [RoutePrefix("api/flights")]
    public class FlightsController : ApiController
    {
        private readonly IFlightTask _flightTask;
        private readonly ISecurityTokenTask _securityToken;

        public FlightsController(IFlightTask flightTask, ISecurityTokenTask securityToken)
        {
            _flightTask = flightTask;
            this._securityToken = securityToken;
        }
        public virtual async Task<HttpResponseMessage> Post(ApiFlightsPostRequest requestContent)
        {
            if (requestContent == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new Notification
                {
                    CmsKey = "GeneralExceptionMessage",
                    DefaultMessage = "Sorry there was a problem. Please try again.",
                    CanContinue = false
                });
            }

            HttpStatusCode statusCode;
            var flightCriteria = new List<Model.Search.FlightCriteria>();
            try
            {
                var searchCriteria = new Model.Search.SearchCriteria
                {
                    Adults = requestContent.PaxInfo.AdultCount.Value,
                    Children = requestContent.PaxInfo.ChildCount.Value,
                    Infants = requestContent.PaxInfo.InfantCount.Value,
                    Flights = requestContent.SearchCriteria.Select((criteria, i) => new Model.Search.FlightCriteria
                    {
                        DepartureDate = DateTime.ParseExact(criteria.Date, "M/d/yy hh:mm tt", CultureInfo.InvariantCulture),
                        Origin = criteria.Origin,
                        Destination = criteria.Dest,
                        FlightDirection = Convert.ToString(criteria.Direction).ToLower(),
                        SegmentId = i + 1
                    }).ToList(),
                    PromoCode = requestContent.PromoCode,
                    IsFlexible = false,
                    CabinType = requestContent.CabinClass ?? "",
                    CurrencyCode = requestContent.CurrencyCode
                };

                List<Notification> validationMessages = ValidateRequest(searchCriteria);
                List<Segments> segments = new List<Segments>();
                var securityData = new SecurityData();
                object securityObj;
                Request.Properties.TryGetValue("securityData", out securityObj);
                securityData = (SecurityData)securityObj;

                if (validationMessages.Any())
                {
                    statusCode = HttpStatusCode.BadRequest;
                }
                else
                {
                    var segmentResults = await this._flightTask.GetFlightFareQuotes(searchCriteria, securityData);
                    segments = new Builders.FlightSearchResultBuilder().BuildResponse(segmentResults, searchCriteria, securityData);
                    statusCode = HttpStatusCode.OK;
                }

                return Request.CreateResponse(statusCode, new ApiFlightsPostOkResponse()
                {
                    Segments = segments,
                    Notifications = validationMessages
                });
            }
            catch (Exception ex)
            {
                // Log exception details
                return Request.CreateResponse(HttpStatusCode.BadRequest, new Notification
                {
                    CmsKey = "GeneralExceptionMessage",
                    DefaultMessage = "Sorry there was a problem. Please try again.",
                    CanContinue = false
                });
            }
        }

        private List<Notification> ValidateRequest(Model.Search.SearchCriteria searchCriteria)
        {
            List<Notification> validationMessages = new List<Notification>();

            bool originEmpty = searchCriteria.Flights.Any(x => string.IsNullOrEmpty(x.Origin));
            bool destinationEmpty = searchCriteria.Flights.Any(x => string.IsNullOrEmpty(x.Destination));

            if (originEmpty)
            {
                validationMessages.Add(BuildValidationMessage("OriginRequiredValidation"));
            }

            if (destinationEmpty)
            {
                validationMessages.Add(BuildValidationMessage("DestinationRequiredValidation"));
            }

            if (searchCriteria.Flights.Any(x => x.DepartureDate == null))
            {
                validationMessages.Add(BuildValidationMessage("DepartureDateRequiredValidation"));
            }


            if (searchCriteria.Flights.Count() == 2)
            {
                Model.Search.FlightCriteria inboundFlight = searchCriteria.Flights.FirstOrDefault(f => f.FlightDirection == "inbound");
                Model.Search.FlightCriteria outboundFlight = searchCriteria.Flights.FirstOrDefault(f => f.FlightDirection == "outbound");
                if (inboundFlight != null && outboundFlight != null && inboundFlight.DepartureDate < outboundFlight.DepartureDate
                    && inboundFlight.Origin == outboundFlight.Destination && inboundFlight.Destination == outboundFlight.Origin)
                {
                    validationMessages.Add(BuildValidationMessage("FlyingBackValidation"));
                }
            }

            if (searchCriteria.Adults + searchCriteria.Children > 9)
            {
                validationMessages.Add(BuildValidationMessage("TotalPassengerValidation"));
            }

            if (searchCriteria.Infants > searchCriteria.Adults)
            {
                validationMessages.Add(BuildValidationMessage("InfantPassengerValidation"));
            }

            //if (!string.IsNullOrEmpty(searchCriteria.PromoCode) && !Regex.IsMatch(searchCriteria.PromoCode, "^[A-Za-z0-9_]+$"))
            //{
            //    validationMessages.Add(BuildValidationMessage("PromoCodeValidation"));
            //}

            return validationMessages;
        }

        private Notification BuildValidationMessage(string key)
        {
            Notification notification = new Notification
            {
                CmsKey = key,
                DefaultMessage = "Validation failed",
            };
            return notification;
        }

        [Route("includedServices")]
        public virtual async Task<HttpResponseMessage> IncludedServices(ApiFlightsPostRequest requestContent)
        {

            if (requestContent == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new Notification
                {
                    CmsKey = "GeneralExceptionMessage",
                    DefaultMessage = "Sorry there was a problem. Please try again.",
                    CanContinue = false
                });
            }

            HttpStatusCode statusCode;
            var flightCriteria = new List<Model.Search.FlightCriteria>();
            try
            {
                var searchCriteria = new Model.Search.SearchCriteria
                {
                    Adults = requestContent.PaxInfo.AdultCount.Value,
                    Children = requestContent.PaxInfo.ChildCount.Value,
                    Infants = requestContent.PaxInfo.InfantCount.Value,
                    Flights = requestContent.SearchCriteria.Select((criteria, i) => new Model.Search.FlightCriteria
                    {
                        DepartureDate = DateTime.ParseExact(criteria.Date, "M/d/yy hh:mm tt", CultureInfo.InvariantCulture),
                        Origin = criteria.Origin,
                        Destination = criteria.Dest,
                        FlightDirection = Convert.ToString(criteria.Direction).ToLower(),
                        SegmentId = i + 1
                    }).ToList(),
                    PromoCode = requestContent.PromoCode,
                    IsFlexible = false,
                    CabinType = requestContent.CabinClass ?? "",
                    CurrencyCode = requestContent.CurrencyCode
                };

                List<Notification> validationMessages = ValidateRequest(searchCriteria);
                List<Segments> segments = new List<Segments>();
                var securityData = new SecurityData();
                object securityObj;
                Request.Properties.TryGetValue("securityData", out securityObj);
                securityData = (SecurityData)securityObj;

                if (validationMessages.Any())
                {
                    statusCode = HttpStatusCode.BadRequest;
                }
                else
                {
                    var includes = await this._flightTask.GetIncludedServices(searchCriteria, securityData);
                    segments = new Builders.FlightSearchResultBuilder().BuildIncludedServiceResponse(includes, searchCriteria);
                    statusCode = HttpStatusCode.OK;
                }

                return Request.CreateResponse(statusCode, new ApiFlightsPostOkResponse()
                {
                    Notifications = validationMessages,
                    Segments = segments,
                });
            }
            catch (Exception ex)
            {
                // Log exception details
                return Request.CreateResponse(HttpStatusCode.BadRequest, new Notification
                {
                    CmsKey = "GeneralExceptionMessage",
                    DefaultMessage = "Sorry there was a problem. Please try again.",
                    CanContinue = false
                });
            }
        }
    }
}
