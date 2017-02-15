using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace NasaProjekt
{
    class Class1
    {
        public class Rootobject
        {
            public string date { get; set; }
            public string explanation { get; set; }
            public string hdurl { get; set; }
            public string media_type { get; set; }
            public string service_version { get; set; }
            public string title { get; set; }
            public string url { get; set; }
        }

        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }




    }
}
