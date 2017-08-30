using System;
using Newtonsoft.Json;

namespace UserProfileApi.DocumentModels
{
    public class BaseDocument
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "table")]
        public string Table { get; set; }

        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }
    }
}
