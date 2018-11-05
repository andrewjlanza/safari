using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using safari.Models;


namespace safari.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class SafariVacationController : ControllerBase
  {
    [HttpGet]
    public IEnumerable<Models.SafariVacation> Get()
    {
      var db = new SafariHWContext();
      return db.SafariVacation;
    }
    [HttpGet("{location}")]
    public IEnumerable<SafariVacation> GetByLocation(string location)
    {
      var db = new SafariHWContext();
      return db.SafariVacation.Where(w => w.LocationOfLastSeen.ToLower() == location.ToLower());
    }
    [HttpPost]
    public ActionResult<SafariVacation> Post([FromBody] SafariVacation seenAnimals)

    {


      var db = new SafariHWContext();

      db.SafariVacation.Add(seenAnimals);
      db.SaveChanges();

      return seenAnimals;
    }
    [HttpPut("{id}")]
    public ActionResult<SafariVacation> Put([FromRoute] int id, [FromBody] SafariVacation updatedData)
    {
      var db = new SafariHWContext();
      var animal = db.SafariVacation.FirstOrDefault(f => f.Id == id);
      if (animal != null)
      {
        // update the values
        animal.CountOfTimesSeen = updatedData.CountOfTimesSeen;
        animal.Species = updatedData.Species;
        animal.LocationOfLastSeen = updatedData.LocationOfLastSeen;
        db.SaveChanges();
        return animal;
      }
      else
      {
        return NotFound(new { id, updatedData });
      }
    }
    [HttpDelete("{animalId}")]
    public ActionResult<SafariVacation> Delete(int animalId)
    {

      var db = new SafariHWContext();
      var animal = db.SafariVacation.FirstOrDefault(f => f.Id == animalId);
      db.SafariVacation.Remove(animal);
      db.SaveChanges();

      return animal;
    }


  }
}

