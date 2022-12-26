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
        internal Settings settings { get; set; }
        internal List<Student> students { get; set; }

        private static readonly string cache_path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + @"\ProtonLight\cache.json";

        public void SaveCache(Cache cache)
        {
            string json = JsonConvert.SerializeObject(cache);
            File.WriteAllText(cache_path, json);
        }

        public Cache LoadCache()
        {
            string json = File.ReadAllText(cache_path);
            return JsonConvert.DeserializeObject<Cache>(json);
        }
    }
}
