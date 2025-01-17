using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index(){
            int saat = DateTime.Now.Hour;
            ViewData["Selamlama"] = saat>12 ? "İyi günler":"Günaydın";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo(){
                Id = 1,
                Location = "İstanbul, ABC Kongre Merkezi",
                Date = new DateTime(2024, 07, 25, 15, 0, 0),
                NumberOfPeople = UserCount

            };


            return View(meetingInfo);//bir model göndererdiğimiz zaman doğrudan gönderebiliyoruz.String bir bilgi olduğunda model tanımlası yapıyorduk.
        }
    }
}