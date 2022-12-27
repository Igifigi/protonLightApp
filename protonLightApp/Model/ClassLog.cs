using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonLightApp.Model
{
    internal class ClassLog
    {
        internal int id { get; set; }
        internal int class_id { get; set; }
        internal int event_id { get; set; }
        internal int points { get; set; }

        public ClassLog(int id, int class_id, int event_id, int points)
        {
            this.id = id;
            this.class_id = class_id;
            this.event_id = event_id;
            this.points = points;
        }
    }
}
