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
    public ActionResult<IEnumerable<SafariVacation>> Get()
    {
      var db = new SafariHWContext();
      return db.SafariVacation;
    }
    [HttpPost]
    public ActionResult<SafariVacation> Post([FromBody] SafariVacation seenAnimals)

    {


      var db = new SafariHWContext();

      db.SafariVacation.Add(seenAnimals);
      db.SaveChanges();

      return seenAnimals;
    }
    [HttpPut("{animalId}")]
    public ActionResult<SafariVacation> Put([FromQuery] int animalId, [FromBody] SafariVacation updatedData)
    {
      var db = new SafariHWContext();
      var animal = db.SafariVacation.FirstOrDefault(f => f.Id == animalId);
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
        return NotFound();
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

