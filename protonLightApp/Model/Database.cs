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

        #region add
        internal void add_event(string name, DateTime date)
        {
            int id = get_lowest_id(ref events);
            Event _event = new Event(id, name, date);
            if(id == events.Count)
                events.Add(_event);
            else
                events[id] = _event;
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
        internal void add_class(string name)
        {
            int id = get_lowest_id(ref classes);
            Class _class = new Class(id, name);
            if(id == classes.Count)
                classes.Add(_class);
            else
                classes[id] = _class;
        }
        internal void add_student_log(int student_id, int event_id, int points)
        {
            int id = get_lowest_id(ref student_logs);
            StudentLog student_log = new StudentLog(id, student_id, event_id, points);
            if (id == student_logs.Count)
                student_logs.Add(student_log);
            else
                student_logs[id] = student_log;
        }
        internal void add_class_log(int class_id, int event_id, int points)
        {
            int id = get_lowest_id(ref class_logs);
            ClassLog class_log = new ClassLog(id, class_id, event_id, points);
            if(id == class_logs.Count)
                class_logs.Add(class_log);
            else
                class_logs[id] = class_log;
        }
        #endregion

        #region remove
        internal void remove_event(int id)
        {
            if (id > events.Count - 1)
                return;
            events[id] = null;
        }
        internal void remove_class(int id)
        {
            if (id > classes.Count - 1)
                return;
            classes[id] = null;
        }
        internal void remove_class_log(int id)
        {
            if (id > class_logs.Count - 1)
                return;
            class_logs[id] = null;
        }
        internal void remove_student(int id)
        {
            if (id > students.Count - 1)
                return;
            students[id] = null;
        }
        internal void remove_student_log(int id)
        {
            if (id > student_logs.Count - 1)
                return;
            student_logs[id] = null;
        }
        #endregion

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
