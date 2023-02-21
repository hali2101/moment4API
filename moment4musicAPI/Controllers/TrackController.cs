using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using moment4musicAPI.Data;
using moment4musicAPI.Models;

namespace moment4musicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly MusicContext _context;

        public TrackController(MusicContext context)
        {
            _context = context;
        }

        // GET: api/Track
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Track>>> GetTracks()
        {
            if (_context.Tracks == null)
            {
                return NotFound();
            }

            //hämtar in även album och kategori med en include
            return await _context.Tracks
                .Include(a => a.Album)
                .Include(c => c.Category)
                .ToListAsync();
        }


        // GET: api/Track/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Track>> GetTrack(int id)
        {
            //hämtar in album och kategori med include
            var track = await _context.Tracks
                .Include(a => a.Album)
                .Include(c => c.Category)
                .FirstOrDefaultAsync(a => a.TrackId == id);

            if (track == null)
            {
                return NotFound();
            }

            return track;
        }

        // GET: api/Category/5
        [HttpGet("{category}/{id}")]
        public async Task<ActionResult<Track>> GetTrackByCategory(int id)
        {
            //hämtar in låtar efter kategori med SQL-fråga samt include för att få med album och kategori
            var track = await _context.Tracks
                .FromSqlRaw("Select * from Tracks where CategoryId" +  "=" + id)
                .Include(a => a.Album)
                .Include(c => c.Category)
                .ToListAsync();

            if (track == null)
            {
                return NotFound();
            }

            return Ok(track);
        }

        // GET: api/Album/5
        [HttpGet("{album}/{id}")]
        public async Task<ActionResult<Track>> GetTrackByAlbum(int id)
        {
            //hämtar in låtar efter kategori med SQL-fråga samt include för att få med album och kategori
            var track = await _context.Tracks
                //använder SQL-fråga
                .FromSqlRaw("Select * from Tracks where AlbumId" + "=" + id)
                .Include(a => a.Album)
                .Include(c => c.Category)
                .ToListAsync();

            if (track == null)
            {
                return NotFound();
            }

            return Ok(track);
        }

        // PUT: api/Track/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrack(int id, Track track)
        {
            if (id != track.TrackId)
            {
                return BadRequest();
            }

            _context.Entry(track).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Track
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Track>> PostTrack(Track track)
        {
          if (_context.Tracks == null)
          {
              return Problem("Entity set 'MusicContext.Tracks'  is null.");
          }
            _context.Tracks.Add(track);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrack", new { id = track.TrackId }, track);
        }

        // DELETE: api/Track/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrack(int id)
        {
            if (_context.Tracks == null)
            {
                return NotFound();
            }
            var track = await _context.Tracks.FindAsync(id);
            if (track == null)
            {
                return NotFound();
            }

            _context.Tracks.Remove(track);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrackExists(int id)
        {
            return (_context.Tracks?.Any(e => e.TrackId == id)).GetValueOrDefault();
        }
    }
}
