using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Artist : Base
    {

        public string Name { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}
