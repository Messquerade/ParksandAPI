using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksandAPI.Models;
using System.Linq;

namespace ParksandAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksandAPIContext _db;

    public ParksController(ParksandAPIContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string statePark, string nationalPark, string activities, int acreage, string location)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (statePark != null)
      {
        if (statePark == "true" || statePark == "yes")
        {
          query = query.Where(entry => entry.StatePark == true);
        }
        else if (statePark == "false" || statePark == "no")
        {
          query = query.Where(entry => entry.StatePark == false);
        }
      }

      if (nationalPark != null)
      {
        if (nationalPark == "true" || nationalPark == "yes")
        {
          query = query.Where(entry => entry.NationalPark == true);
        }
        else if (nationalPark == "false" || nationalPark == "no")
        {
          query = query.Where(entry => entry.NationalPark == false);
        }
      }

      if (activities != null)
      {
        query = query.Where(entry => entry.Activities.Contains(activities));
      }

      if (acreage != 0)
      {
        query = query.Where(entry => entry.Acreage == acreage);
      }
      
      if (location != null)
      {
        query = query.Where(entry => entry.Address.Contains(location));
      }
      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId}, park);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
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
    
    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }
      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}