using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SafariVacation.Models;

namespace SafariVacation.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SearchController : ControllerBase
  {
    [HttpGet]
    public IQueryable<SafariVacation> Search(string searchTerm)
    {
      var db = new SafariAPIContext();
      var searchResults = db.SafariVacation.Where(w => w.Species.ToLower().Contains(searchTerm.ToLower()));

      return searchResults;
    }
  }
}