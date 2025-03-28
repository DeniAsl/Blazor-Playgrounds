using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pin.OpenData.Core.Entities
{
    public class Playground
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Title is too long (max 50 characters).")]
        [JsonPropertyName("titel")]
        public string Title { get; set; }

        [Required]
        [JsonPropertyName("lokale_beschrijving")]
        public string LocalDescription { get; set; }

        [JsonPropertyName("beschrijving")]
        public string Description { get; set; }

        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }


        [Required]
        [JsonPropertyName("themas")]
        public string Themes { get; set; }
    }
}
