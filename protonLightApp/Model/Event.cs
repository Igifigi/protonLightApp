using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonLightApp.Model
{
    internal class Event
    {
        internal int id { get; set; }
        internal string name { get; set; }
        internal DateTime date { get; set; }

        public Event(int id, string name, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.date = date;
        }
    }
}
