using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPublishingAssessment.Models
{
    public class JsonDictionary
    {
        public Dictionary<string, JsonData> JsonDict { get; set; }
        public JsonDictionary()
        {
            JsonDict = new Dictionary<string, JsonData>();
        }
    }
}
