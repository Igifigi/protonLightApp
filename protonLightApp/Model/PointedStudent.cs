using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonLightApp.Model
{
    internal class PointedStudent : Student
    {
        public int points;
        public PointedStudent(int id, string name, string surname, int class_id, int gender, int points) : base(id, name, surname, class_id, gender)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.class_id = class_id;
            this.surname = surname;
            this.points = points;
        }
    }
}
