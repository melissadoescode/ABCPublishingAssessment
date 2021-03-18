using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPublishingAssessment.Models
{
    public class JsonData
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("content")]
        public List<string> Content { get; set; }
        [JsonProperty("navigation")]
        public List<Navigation> Navigation { get; set; }
    }
}
