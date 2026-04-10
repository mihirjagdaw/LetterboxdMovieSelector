using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MovieSelector.Shared.Models
{
    public class YtsMovieResult
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("medium_cover_image")]
        public string? MediumCoverImage { get; set; } = "";

        [JsonPropertyName("large_cover_image")]
        public string? LargeCoverImage { get; set; } = "";

        [JsonPropertyName("torrents")]
        public List<YtsTorrent>? Torrents { get; set; }
    }
}
