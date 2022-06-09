using kolokwium2.Models;
using kolokwium2.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Services
{
    public class MusicService : IMusicService
    {

        public readonly MusicDbContext _context;

        public MusicService(MusicDbContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<MusicianGet>> GetMusician(int id)
        {
            
                return await _context.Musicians.Where(e => e.IdMusician == id).Select(e => new MusicianGet
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Nickname = e.Nickname
                }).ToListAsync();
            
        }
    }
}
