using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Runtime.InteropServices;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminIndex()
        {
            return View();
        }
        
        public IActionResult CreateUser()
        {
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
