using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Musician_Track
    {
        public virtual Musician Musician { get; set; }
        public virtual Track Track { get; set; }

    }
}
