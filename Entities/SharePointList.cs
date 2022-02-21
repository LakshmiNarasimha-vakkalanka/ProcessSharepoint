using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessSharePoint.Entities
{
    public class SharePointList
    {
        [JsonProperty(PropertyName = "@odata.context")]
        public string odataContext { get; set; }
        public List<value> value { get; set; }
    }
}
