using Microsoft.AspNetCore.Mvc;
using LeQuangThanhBTH.Models;

namespace LeQuangThanhBTH.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            // khoi tao 1 list Person 
            List<Person> stdList = new List<Person>()
            {
                new Person{PersonID = 1, PersonName="LeQuangThanhh", PersonAge = 19},
                new Person{PersonID = 2, PersonName="LeQuangThanhhh", PersonAge = 19},
                new Person{PersonID = 3, PersonName="LeQuangThanhhhh", PersonAge = 19},
                new Person{PersonID = 4, PersonName="LeQuangThanhhhhh", PersonAge = 19},
                new Person{PersonID = 5, PersonName="LeQuangThanhhhhhh", PersonAge = 19}

            };
            ViewData["Person"] = stdList;
            return View(stdList);
        }
        [HttpPost]
        //     public IActionResult Index(string PersonID, string PersonName, string PersonAge)
        //     {
        //         // ViewBag.mess = std.PersonID + "-" + std.PersonName + "-" + std.PersonAge;
        //         ViewBag.mess = "Mã sinh viên: " + PersonID + " ; " + "  Tên sinh viên: " + PersonName + " ; " + "Tuổi: " + PersonAge;
        //         return View();
        //     }
        // }

        public IActionResult Create(Person std)
        {
            string message = std.PersonID + "-";
            message += std.PersonName + "-";
            message += std.PersonAge;
            ViewBag.TT = message;
            return View();
        }
    }
}