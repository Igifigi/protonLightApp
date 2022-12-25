using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonLightApp.Model
{
    internal class Class
    {
        public int id { get; set; }
        public string name { get; set; }

        public Class(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
