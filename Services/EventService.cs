using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using System.Xml.Linq;
using Newtonsoft.Json;
using Worker.Helpers;
using System.Xml;
using System.Text;
using RestSharp;

namespace Worker.Services
{
    public class EventService
    {
        private RestClient _restClient;

        public EventService()
        {
            _restClient = WebWrapper.GetClient();
        }

        public Events GetAllEventsForToday()
        {
            try
            {
                var endPointForCourse = "event?date_from={{eventsDateFrom}}&date_to={{eventsDateTo}}";
                endPointForCourse = endPointForCourse.Replace("{{eventsDateFrom}}", JRDateTimeConvert.ConvertToJRDateTimeFormat(DateTime.Now));
                endPointForCourse = endPointForCourse.Replace("{{eventsDateTo}}", JRDateTimeConvert.ConvertToJRDateTimeFormat(DateTime.Now));
                RestRequest request = new RestRequest(endPointForCourse);
                request.Method = Method.GET;
                var responseStream = _restClient.Execute(request);
                var response = responseStream.Content;
                var doc = XDocument.Parse(response);
                var json = JsonConvert.SerializeXNode(doc.Descendants("events").FirstOrDefault());
                var eventRoot = JsonConvert.DeserializeObject<EventsRoot>(json);
                return eventRoot.events;
            }
            catch (Exception ex)
            {
                return new Events();
            }
        }


        //public async Task<Event> GetEvent(string eventId)
        //{
        //    try
        //    {
        //        var endPointForCourse = _settings.EndPoints.Event;
        //        endPointForCourse = endPointForCourse.Replace("{{eventId}}", eventId);
        //        var responseStream = await _httpClient.GetAsync(endPointForCourse);
        //        var response = await responseStream.Content.ReadAsStringAsync();
        //        var doc = XDocument.Parse(response);
        //        var json = JsonConvert.SerializeXNode(doc.Descendants("event").FirstOrDefault());
        //        var eventRoot = JsonConvert.DeserializeObject<EventRoot>(json);
        //        return eventRoot.Event;
        //    }
        //    catch (Exception ex)
        //    {
        //        var error = new ExceptionModel { ErrorCode = "EventError:001", ErrorMessage = ex.Message };
        //        return new Event();
        //    }
        //}

        //public async Task<InviteeRoot> GetAllInviteesForTheEvent(string courseId, string eventId)
        //{
        //    try
        //    {
        //        var endPointForCourse = _settings.EndPoints.PartiesInThatCourseEvent;
        //        endPointForCourse = endPointForCourse.Replace("{{courseId}}", courseId);
        //        endPointForCourse = endPointForCourse.Replace("{{eventId}}", eventId);
        //        var responseStream = await _httpClient.GetAsync(endPointForCourse);
        //        var response = await responseStream.Content.ReadAsStringAsync();
        //        var doc = XDocument.Parse(response);
        //        var json = JsonConvert.SerializeXNode(doc.Descendants("invitees").FirstOrDefault());
        //        return JsonConvert.DeserializeObject<InviteeRoot>(json);
        //    }
        //    catch (Exception ex)
        //    {
        //        var error = new ExceptionModel { ErrorCode = "EventError:002", ErrorMessage = ex.Message };
        //        return new InviteeRoot();
        //    }
        //}

        public Attendees GetEventAttendees(string courseId, string eventId)
        {
            try
            {
                var endPoint = "courses/{{courseId}}/events/{{eventId}}/attendees";
                endPoint = endPoint.Replace("{{courseId}}", courseId);
                endPoint = endPoint.Replace("{{eventId}}", eventId);
                var request = new RestRequest(endPoint);
                request.Method = Method.GET;
                var responseStream =  _restClient.Execute(request);
                var response = responseStream.Content;
                var doc = XDocument.Parse(response);
                var json = JsonConvert.SerializeXNode(doc.Descendants("attendees").FirstOrDefault());
                return JsonConvert.DeserializeObject<AttendeesRoot>(json).Attendees;
            }
            catch (Exception ex)
            {
                return new Attendees();
            }
        }

        public  string GetEventAttendeesAsXML(string courseId, string eventId)
        {
            try
            {
                var endPoint = "courses/{{courseId}}/events/{{eventId}}/attendees";
                endPoint = endPoint.Replace("{{courseId}}", courseId);
                endPoint = endPoint.Replace("{{eventId}}", eventId);
                var request = new RestRequest(endPoint);
                request.Method = Method.GET;
                var responseStream = _restClient.Execute(request);
                var response = responseStream.Content;
                return response;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

    }
}
