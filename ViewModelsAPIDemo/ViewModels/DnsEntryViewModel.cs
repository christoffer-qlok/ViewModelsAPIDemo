using System.Text.Json.Serialization;

namespace ViewModelsAPIDemo.ViewModels
{
    public class DnsEntryViewModel
    {
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }

        [JsonPropertyName("ip_addr")]
        public string[] IpAddr { get; set; }
    }
}
