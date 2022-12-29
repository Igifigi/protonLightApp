using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonLightApp.Model
{
    internal class StudentLog
    {
        internal int id { get; set; }
        internal int student_id { get; set; }
        internal int event_id { get; set; }
        internal int points { get; set; }

        public StudentLog(int id, int student_id, int event_id, int points)
        {
            this.id = id;
            this.student_id = student_id;
            this.event_id = event_id;
            this.points = points;
        }
    }
}
