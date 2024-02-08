using Microsoft.AspNetCore.Mvc;
using RIMANDO_Act2_CC1.Models;
using System.Diagnostics;

namespace RIMANDO_Act2_CC1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }









        public IActionResult ToDoPage()
        {


            List<ToDo> toDoList = new List<ToDo>
            {
                new ToDo { ItemID = 1, Item = "Item 1" },
                new ToDo { ItemID = 2, Item = "Item 2" },
                new ToDo { ItemID = 3, Item = "Item 3" },
                new ToDo { ItemID = 4, Item = "Item 4" },
                new ToDo { ItemID = 5, Item = "Item 5" }
            };
            return View(toDoList);
        }











        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}