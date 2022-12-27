using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace protonLightApp.Model
{
    internal class Cache
    {
        private static readonly string cache_path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + @"\ProtonLight\cache.json";

        internal Settings settings { get; set; }
        internal List<Class> classes { get; set; }
        internal List<ClassLog> class_logs { get; set; }
        internal List<Student> students { get; set; }
        internal List<StudentLog> student_logs { get; set; }
        internal List<Event> events { get; set; }

        public Cache()
        {
            settings = new Settings();
            classes = new List<Class>();
            class_logs = new List<ClassLog>();
            students = new List<Student>();
            student_logs = new List<StudentLog>();
            events = new List<Event>();
        }
        

        public static void SaveCache(Cache cache)
        {
            string json = JsonConvert.SerializeObject(cache);
            File.WriteAllText(cache_path, json);
        }

        public static Cache LoadCache()
        {
            if (!File.Exists(cache_path))
                return new Cache();
            string json = File.ReadAllText(cache_path);
            return JsonConvert.DeserializeObject<Cache>(json);
        }


        //public void LoadCache()
        //{
        //    string json = File.ReadAllText(cache_path);
        //    Cache cache = JsonConvert.DeserializeObject<Cache>(json);
        //    this.settings = cache.settings;
        //    this.classes = cache.classes;
        //    this.class_logs = cache.class_logs;
        //    this.students = cache.students;
        //    this.student_logs = cache.student_logs;
        //    this.events = cache.events;
        //}
    }
}
