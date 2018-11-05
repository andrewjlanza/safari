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
  public class SearchController : ControllerBase
  {
    [HttpGet]

    public ActionResult Get([FromQuery]String species)
    {
      var db = new SafariHWContext();
      var results = db.SafariVacation.Where(w => w.Species.Contains(species));


      //return all species where 'r' is included
      return Ok(results);
    }

  }



}
