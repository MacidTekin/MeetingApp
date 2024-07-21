using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {

        [HttpGet]
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {   //Modelden bir nesne türetildiğinde isValid isimli bir property var bunun trueolması modelin hiçbir validations kuralına takılmamasıdemek
            if(ModelState.IsValid){
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
                    return View("Thanks",model);  
            }else{
                return View(model);
            }
            
        }

        [HttpGet]
        public IActionResult List(){ //Bize gelen user bilgilerini liste gonderlim ve bu listi dinamik hale getirelim
            return View(Repository.Users);
        }

        public IActionResult Details(int id){   //meeting/details/2 vs.
            return View(Repository.GetById(id));
        }
    }
}