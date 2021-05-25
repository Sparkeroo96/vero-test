using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Song : Base
    {
        public string Name { get; set; }
        public string Lyrics { get; set; }
        public string CoverFilePath { get; set; } //Images would be stored in a seperate folder, we would store the link of it here
        public decimal Price { get; set; }
        public Guid ArtistId { get; set; }

        public Artist Artist { get; set; }
    }
}
