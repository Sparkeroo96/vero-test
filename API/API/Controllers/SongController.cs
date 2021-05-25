using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {

        private readonly MusicContext _context;

        public SongController(MusicContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Song>>> GetAll()
        {
            return _context.Songs.ToList();
        }

        // GET api/<SongController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Song>> Get(Guid id)
        {
            var song = _context.Songs
                    .Where(s => s.Id == id)
                    .Include(a => a.Artist)
                    .SingleOrDefault();


            return song;
        }

        // Extra endpoints could be added to add extra functionality
        // Put request to Add extra value

    }
}
