using System.Collections.Generic;

namespace protonLightApp.Model
{
    internal class Ranking
    {
        internal readonly List<PointedStudent> students;
        internal readonly List<PointedClass> classes;

        public Ranking(List<PointedStudent> students, List<PointedClass> classes)
        {
            this.students = students;
            this.classes = classes;
        }
    }
}
