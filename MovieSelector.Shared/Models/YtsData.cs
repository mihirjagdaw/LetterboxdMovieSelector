using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MovieSelector.Shared.Models
{
    public class YtsData
    {
        [JsonPropertyName("movies")]
        public List<YtsMovieResult>? Movies { get; set; }
    }
}
