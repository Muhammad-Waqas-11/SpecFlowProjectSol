using SpecFlowProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpecFlowProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult TestPage(string one)
        {
            // Initial GET request, return the view with an empty model
            return View();
        }
        [HttpPost]
        public ActionResult TestPage()
        {
            if (Request.HttpMethod == "POST")
            {
                // Get form data
                var fullName = Request.Form["fullName"];
                var dob = Request.Form["dob"]; // String representation of date
                var address = Request.Form["address"];
                var phoneNumber = Request.Form["phoneNumber"];
                var occupation = Request.Form["occupation"];

                // Create model instance
                var model = new TestPageModel
                {
                    FullName = fullName,
                    DOB = string.IsNullOrEmpty(dob) ? null : (DateTime?)DateTime.Parse(dob),  // Handle empty date
                    Address = address,
                    PhoneNumber = phoneNumber,
                    Occupation = occupation
                };

                // Validate model (optional)
                if (ModelState.IsValid)
                {
                    // Save data to database or perform other actions
                    // ... (Your logic to use the model data)

                    ViewBag.Message = "Form submitted successfully!";
                    return RedirectToAction("SuccessPage");
                }
                else
                {
                    // Model validation failed, display errors
                    ViewBag.Message = "Please correct the errors in the form.";
                    return View();
                }
            }

            // Initial GET request, return the view with an empty model
            return View(new TestPageModel());
        }

        public ActionResult SuccessPage(string one)
        {
            // Initial GET request, return the view with an empty model
            return View();
        }
        public ActionResult Calculator()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}