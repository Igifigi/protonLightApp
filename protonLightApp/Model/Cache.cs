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

        internal Settings settings;
        internal Database database;

        public Cache()
        {
            settings = new Settings();
            database = new Database();
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
    }
}
