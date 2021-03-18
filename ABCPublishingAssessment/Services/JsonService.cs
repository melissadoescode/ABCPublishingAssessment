using ABCPublishingAssessment.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPublishingAssessment.Services
{
    public class JsonService
    {
        public static JsonDictionary DeserializeJson()
        {
            var dict = new JsonDictionary();
            string path = @"C:\Users\MelissaG\source\repos\ABCPublishingAssessment\ABCPublishingAssessment\wwwroot\sherlock.json";
            JObject json = JObject.Parse(File.ReadAllText(path));
            var properties = json.Properties();
            foreach (var item in properties)
            {
                var x = JsonConvert.DeserializeObject<JsonData>(item.FirstOrDefault().ToString());
                dict.JsonDict.Add(item.Name, x);
            }
            return dict;
        }
    }
}
