using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessSharePoint.Entities
{
    class SharePointSite
    {
        [JsonProperty(PropertyName = "@odata.context")]
        public string odataContext { get; set; }
        public string createdDateTime { get; set; }
        public string description { get; set; }
        public string id { get; set; }
        public string lastModifiedDateTime { get; set; }
        public string name { get; set; }
        public string webUrl { get; set; }
        public string displayName { get; set; }
        public object root { get; set; }
    }
}
