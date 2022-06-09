using kolokwium2.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Services
{
   public interface IMusicService
    {
        public Task<IEnumerable<MusicianGet>> GetMusician(int id);

    }
}
