using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonLightApp.Model
{
    internal class PointedClass : Class
    {
        internal int points;
        public PointedClass(int id, string name, int points) : base(id, name)
        {
            this.points = points;
            this.name = name;
            this.id = id;
        }
    }
}
