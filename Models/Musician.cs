using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Musician
    {
        public int IdMusician { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Nickname { get; set; }

        public virtual IEnumerable<Musician_Track> Musician_Tracks { get; set; }
    }
}
