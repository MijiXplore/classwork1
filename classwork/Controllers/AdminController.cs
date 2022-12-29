using Microsoft.AspNetCore.Mvc;
using classwork.Models;

namespace classwork.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminIndex()
        {
            return View();
        }

        //GET
        public IActionResult CreateUser()
        {
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult CreateUser(user obj)
        {
            /*if (obj.password != obj.password)
            {
                ModelState.AddModelError("password", "Password must match with Confirm Password");
            }*/

            if (ModelState.IsValid)
            {
                return RedirectToAction("AddUser","Home");
            }
            return View();
        }

       public  IActionResult ShowUsers(string error ="")
        {
            //Database call to get the list of available users
            ViewBag.usersList = userData.userList;
            
            if(error != null)
            {
                RedirectToAction("UserError", "Admin");

            }
            else
            {
                return View();
            }

            //Console.WriteLine(userData.userList);
            return View();
   
        }

        public IActionResult DeleteUser()
        {

            ViewBag.usersList = userData.userList;
            return View();
        }

        public IActionResult UserError()
        {

            ViewBag.usersList = userData.userList;
            ViewBag.newerrorMessage = "the user was not found";
            return View();
        }



    }
}
