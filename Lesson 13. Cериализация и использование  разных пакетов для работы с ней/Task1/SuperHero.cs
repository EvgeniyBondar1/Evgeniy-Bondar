using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task1
{
    public class SuperHero
    {
        [JsonPropertyName("squadName")]
        public string SquadName { get; set; }

        [JsonPropertyName("homeTown")]
        public string HomeTown { get; set; }

        [JsonPropertyName("formed")]
        public string Formed { get; set; }

        [JsonPropertyName("secretBase")]
        public string SecretBase { get; set; }

        [JsonPropertyName("active")]
        public string Active { get; set; }

        [JsonPropertyName("members")]
        public Members [] Members  { get; set; }


    }
}
