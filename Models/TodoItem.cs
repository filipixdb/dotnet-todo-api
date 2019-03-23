using Newtonsoft.Json;

namespace TodoApi.Models
{
    public class TodoItem
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "complete")]
        public bool isComplete { get; set; }
    }
}