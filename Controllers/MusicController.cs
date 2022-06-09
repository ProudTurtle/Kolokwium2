using kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicController : ControllerBase
    {
        private readonly IMusicService _service;

        public MusicController(IMusicService service) 
        {
            _service = service;
        }




        [HttpGet("{id}")]
        public async Task<IActionResult> GetMusician(int id)
        {
            var result = await _service.GetMusician(id);
            if (result == null) return NoContent();
            return Ok(result);
        }


    }
}
