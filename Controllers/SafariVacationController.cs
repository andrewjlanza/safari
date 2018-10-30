using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SafariVacationApi.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class SafariVacationController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<SeenAnimals>> Get()
    {
      var db = new SafariVacationContext();
      return db.SeenAnimals;
    }
  }
}
