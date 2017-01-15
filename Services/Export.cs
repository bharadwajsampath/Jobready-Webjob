using Models;
using Models.Models;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Worker.Helpers;
using Worker.Services;

namespace MailService.Services
{
    public static class Export
    {
        public static void ClassList()
        {
            EventService _eventService = new EventService();
            PartyService _partyService = new PartyService();
            var exportStudentList = new List<ExportStudent>();
            var @events = _eventService.GetAllEventsForToday();
            foreach (var @event in @events.Event)
            {
                var trainer = _partyService.Get(@event.trainer);
                var trainerEmail = string.Empty;
                if(trainer.Party.contactdetails != null && trainer.Party.contactdetails.contactdetail != null)
                {
                    trainerEmail = trainer.Party.contactdetails.contactdetail.FirstOrDefault(x => x.contacttype == "Email").value;
                }
                var attendees = (_eventService.GetEventAttendees(@event.coursenumber, @event.EventId.ToString())).Attendee;
                if (attendees != null)
                {
                    foreach (Attendee student in attendees)
                    {
                        var exportStudent = new ExportStudent();
                        var party = _partyService.Get(student.partyId);
                        exportStudent.PartyId = student.partyId;
                        exportStudent.FullName = $"{party.Party.firstname} {party.Party.surname}";
                        exportStudent.IsPresent = student.attended;
                        exportStudent.Notes = student.notes;
                        exportStudent.TimeArrived = student.arrivedAt;
                        exportStudent.TimeLeft = student.leftAt;
                        exportStudent.Duration = student.duration;
                        exportStudent.AbsentReason = student.absencereason;
                        exportStudentList.Add(exportStudent);
                    }

                    var attachment = XMLHelper.ConvertToXML(exportStudentList);
                    Email email = new Email();
                    email.Attachment = attachment;
                    email.FileName = @event.title.ToString().Replace(" ", "_");
                    email.CC = trainerEmail;
                    email.BCC = "admin@bajjus.com";
                    email.To = "assessments@bcanational.com";
                    email.Subject = $"Attendance for the course :{@event.coursenumber}/{@event.title}";
                    email.Text = $"Please find the attached attendance sheet for the event {@event.coursenumber}/{@event.title}";
                    var result = EmailService.SendMail(email);
                    Console.WriteLine($"Sent Email {email.Subject} to {email.To} and {email.CC} at {DateTime.Now}");
                }
                Console.WriteLine($"No attendees for the course {@event.coursenumber} checked: at {DateTime.Now}");
            }
            Console.WriteLine($"No events scheduled checked: at {DateTime.Now}");
        }

    }
}
