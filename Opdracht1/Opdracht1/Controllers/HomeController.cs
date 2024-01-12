// HomeController.cs
namespace Opdracht1.Models
{


    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserModel user)
        {
            if (ModelState.IsValid)
            {
                // Process the user data (e.g., save to a database)
                // You can also redirect to a success page
                return Content("Data submitted successfully!");
            }

            // If the model is not valid, return to the same view with validation errors
            return View(user);
        }
    }
}