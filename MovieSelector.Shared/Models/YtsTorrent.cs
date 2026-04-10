using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MovieSelector.Shared.Models
{
    public class YtsTorrent
    {
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }

        [JsonPropertyName("quality")]
        public string? Quality { get; set; } = "";

        [JsonPropertyName("size")]
        public string? Size { get; set; } = "";
    }
}
