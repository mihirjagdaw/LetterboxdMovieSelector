using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MovieSelector.Shared.Models
{
    public class YtsResponse
    {
        [JsonPropertyName("data")]
        public YtsData? Data { get; set; }
    }
}
