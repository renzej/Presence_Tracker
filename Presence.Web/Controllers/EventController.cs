using Microsoft.AspNetCore.Mvc;
using Presence.Web.Data;
using Presence.Web.Models;

namespace Presence.Web.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EventController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Event> objEventList = _db.Events.ToList();

            return View(objEventList);
        }
    }
}
