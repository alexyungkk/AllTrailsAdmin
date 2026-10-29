using AllTrailsAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AllTrailsAdmin.Controllers
{
    public class HomeController : Controller
    {
        //Constructor
        public HomeController()
        {
            Console.WriteLine("Constructor is called");
        }

        // Action method /Index
        public IActionResult Index()
        {
            Console.WriteLine("Hello from the Home/Index.");
            return View();
        }

        //Action method /Privacy
        public IActionResult Privacy()
        {
            Console.WriteLine("Hello from the Home/Privacy.");
            return View();
        }
        // Try Action method /Hello
        public IActionResult HelloWorld()
        {
            Console.WriteLine("Hello from the Home/HelloWorld.");
            return View();
        }

        public IActionResult GetTrail()
        {
            //create a sample trail object (later, we will pull this from db)
            Trail trail = new Trail();
            trail.Id = 1;
            trail.Title = "Pot Lake Trail";
            trail.Description = "A scenic trail with beautiful views fo the Lake.";
            trail.Length = 5.2;
            trail.ElevationGain = 300;
            trail.Location = "Pot Lake Loop, Otter Lake, NS B3Z 1A9";

            return View(trail); //pass trail object into view to display the trail details
        }


        // add an Action method to display a list of trails
        public IActionResult GetAllTrails ()
        {
            var trails = new List<Trail>();

            Trail trail1 = new Trail();
            trail1.Id = 1;
            trail1.Title = "Pot Lake Trail";
            trail1.Description = "A scenic trail with beautiful views fo the Lake.";
            trail1.Length = 5.2;
            trail1.ElevationGain = 300;
            trail1.Location = "Pot Lake Loop, Otter Lake, NS B3Z 1A9";

            Trail trail2 = new Trail();
            trail2.Id = 1;
            trail2.Title = "Johnson Lake";
            trail2.Description = "A scenic trail with beautiful views of the lake.";
            trail2.Length = 6.7;
            trail2.ElevationGain = 100;
            trail2.Location = "Otter Lake, NS B3Z 1A9";

            Trail trail3 = new Trail();
            trail3.Id = 1;
            trail3.Title = "Point Pleasant Park";
            trail3.Description = "A scenic trail with beautiful views of the lake.";
            trail3.Length = 9.2;
            trail3.ElevationGain = 2123;
            trail3.Location = "NS B3Z 1A9";

            trails.Add(trail1);
            trails.Add(trail2);
            trails.Add(trail3);

            return View(trails);
        }
    }
}
