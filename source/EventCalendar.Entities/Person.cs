using System;
using System.Collections.Generic;
using System.Text;

namespace EventCalendar.Entities
{

    /// <summary>
    /// Person kann sowohl zu einer Veranstaltung einladen,
    /// als auch an Veranstaltungen teilnehmen
    /// </summary>
    public class Person : IComparable<Person>
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public List<Event> Events { get; set; }


        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
            Events = new List<Event>();
        }

        public int CompareTo(Person other)
        {
            if(this.Events.Count > other.Events.Count)
            {
                return -1;
            }
            else if(this.Events.Count < other.Events.Count)
            {
                return 1;
            }
            else
            {
                if(this.LastName.CompareTo(other.LastName) > 0)
                {
                    return 1;
                }
                else if(this.LastName.CompareTo(other.LastName) < 0)
                {
                    return -1;
                }
                else
                {
                    return this.FirstName.CompareTo(other.FirstName);
                }
            }

        }
    }
}