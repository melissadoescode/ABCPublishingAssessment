using ABCPublishingAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPublishingAssessment.Services
{
    public class GetDictionaryData
    {
        public static JsonData GetDictionaryValues(Dictionary<string, JsonData> kvp, string key)
        {
            foreach (var item in kvp)
            {
                if (item.Key == key)
                {
                    return item.Value;
                }
            }
            return new JsonData();
        }
    }
}
