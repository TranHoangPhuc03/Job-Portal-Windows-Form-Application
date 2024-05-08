using FindJobApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobApplication.Daos
{
    public class EventDao
    {
        private QLXinViecDFContext db = null;
        public EventDao()
        {
            db = new QLXinViecDFContext();
        }
        public int SaveNewEvent(InterviewEvent interviewEvent)
        {
            db.InterviewEvents.Add(interviewEvent);
            int c = db.InterviewEvents.Count();
            return db.SaveChanges();
        }
        public int DeleteEventById(int idEvent)
        {
            InterviewEvent interviewEvent = db.InterviewEvents.Find(idEvent);
            if (interviewEvent != null)
            {
                db.InterviewEvents.Remove(interviewEvent);
                return db.SaveChanges();
            }
            return 0;
        }

        public ICollection<InterviewEvent> FindEventInDateById(int idCompany, DateTime dateTime)
        {
            var events = db.InterviewEvents
                           .Where(e => e.CompanyId == idCompany &&
                                       e.From.Year == dateTime.Year &&
                                       e.From.Month == dateTime.Month &&
                                       e.From.Day == dateTime.Day)
                           .ToList();

            return events;
        }

    }
}
