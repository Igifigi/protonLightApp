using System;
using System.Collections.Generic;

namespace protonLightApp.Model
{
    internal class Database
    {
        private List<Event> events;
        private List<Class> classes;
        private List<ClassLog> class_logs;
        private List<Student> students;
        private List<StudentLog> student_logs;

        public Database()
        {
            events = new List<Event>();
            classes = new List<Class>();
            class_logs = new List<ClassLog>();
            students = new List<Student>();
            student_logs = new List<StudentLog>();
        }

        internal void add_student(string name, string surname, int class_id, int gender)
        {
            int id = get_lowest_id(ref students);
            Student student = new Student(id, name, surname, class_id, gender);
            if (id == students.Count)
                students.Add(student);
            else
                students[id] = student;
        }
        internal void delete_student(int id)
        {
            if (students.Count - 1 < id)
                return;
            students[id] = null;
        }
        #region get_lowest_id
        private int get_lowest_id(ref List<Event> list)
        {
            for (int iterator = 0; iterator < list.Count; iterator++)
                if (list[iterator] == null)
                    return iterator;
            return list.Count;
        }
        private int get_lowest_id(ref List<Class> list)
        {
            for (int iterator = 0; iterator < list.Count; iterator++)
                if (list[iterator] == null)
                    return iterator;
            return list.Count;
        }
        private int get_lowest_id(ref List<ClassLog> list)
        {
            for (int iterator = 0; iterator < list.Count; iterator++)
                if (list[iterator] == null)
                    return iterator;
            return list.Count;
        }
        private int get_lowest_id(ref List<Student> list)
        {
            for (int iterator = 0; iterator < list.Count; iterator++)
                if (list[iterator] == null)
                    return iterator;
            return list.Count;
        }
        private int get_lowest_id(ref List<StudentLog> list)
        {
            for (int iterator = 0; iterator < list.Count; iterator++)
                if (list[iterator] == null)
                    return iterator;
            return list.Count;
        }
        #endregion
    }
}
