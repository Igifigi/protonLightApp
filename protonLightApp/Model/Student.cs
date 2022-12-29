using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonLightApp.Model
{

    internal class Student
    {

        internal int id { get; set; }
        internal string name { get; set; }
        internal string surname { get; set; }
        internal int class_id { get; set; }
        internal int gender { get; set; } //1 - boy, 0 - girl

        public Student(int id, string name, string surname, int class_id, int gender)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.class_id = class_id;
            this.gender = gender;
        }

        internal enum Gender
        {
            Female = 0,
            Male = 1
        }
    }
}
