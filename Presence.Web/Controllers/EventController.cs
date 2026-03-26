using Microsoft.AspNetCore.Mvc;
using Presence.Web.Data;
using Presence.Web.Helpers;
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

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var events = _db.Events.ToList().Select(e => new {
                id = e.Id,
                name = e.Name,
                startDateTime = e.StartDateTime,
                endDateTime = e.EndDateTime,
                type = e.Type.GetDisplayName(),
                status = e.Status.GetDisplayName()
            });

            return Json(new { data = events });
        }
        #endregion
    }
}
