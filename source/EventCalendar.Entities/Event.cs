using System;
using System.Collections.Generic;

namespace EventCalendar.Entities
{
    public class Event : IComparable<Event>
    {
        private string _title;

        public string Title {
            get 
            {
                return _title;
            }
            set 
            {
                if (value != null)
                {
                    _title = value;
                }
                else
                {
                    throw new NullReferenceException(nameof(value));
                }

            }
        }

        public List<Person> Participants { get; set; }

        public DateTime Time { get; set; }
        public Person Invitor { get; set; }
        public int MaxParticipants { get; set; }

        public Event(Person invitor, string title, DateTime dateTime, int participants = 0)
        {
            Invitor = invitor;
            Title = title;
            Time = dateTime;
            MaxParticipants = participants;
            Participants = new List<Person>();
        }

        public int CompareTo(Event other)
        {
            return this.Time.CompareTo(other.Time);
        }
    }
}
