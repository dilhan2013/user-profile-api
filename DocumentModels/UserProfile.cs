using Newtonsoft.Json;

namespace UserProfileApi.DocumentModels
{
    public class UserProfile : BaseDocument
    {
        public UserProfile()
        {
            Table = "user-profile";
            TenantId = "public";
        }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
