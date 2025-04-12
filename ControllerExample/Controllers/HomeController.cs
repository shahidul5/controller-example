using ControllerExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("bookstore")]
        public IActionResult Index(int? bookId)
        {
            if (bookId.HasValue == false)
            {
                return BadRequest("BookId is required");
            }
            if (bookId <= 0)
            {
                return BadRequest("BookId should be greater than 0");
            }
            return Json("shahid");
        }
        [Route("person")]
        public JsonResult PersonDetails()
        {
            Person person = new Person() { Id = new Guid(), FirstName = "Shahidul", LastName = "Islam" };
            return Json(person);
        }
    }
}
