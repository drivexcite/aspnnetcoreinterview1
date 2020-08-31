using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TraderMikes.Entities;

namespace TraderMikes.Controllers
{
    [ApiController]
    public class LocationsController : ControllerBase
    {
        [HttpGet]
        [Route("locations/{locationId}")]
        public IActionResult GetLocationsById(int locationId)
        {
            var options = new DbContextOptionsBuilder<TraderMikesDb>()
                .UseSqlServer("Server=(local);Database=TraderMikesDb;Trusted_Connection=True;")
                .Options;

            var db = new TraderMikesDb(options);
            var location = db.Locations.FirstOrDefaultAsync(l => l.LocationId == locationId).GetAwaiter().GetResult();

            return Ok(location);
        }
    }
}
