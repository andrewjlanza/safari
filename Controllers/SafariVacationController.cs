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
  }
}
