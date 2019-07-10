using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PeluqueriaCanWash.Models;
using PeluqueriaCanWash.Servicios;

namespace PeluqueriaCanWash.Controllers
{

    

    public class LoginController : Controller
    {
   

        LoginServicio loginServicio = new LoginServicio();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginServicio login)
        {
           if(loginServicio.VerificarLogin(login) == 0)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Usuarios");
            }
        }


     

    }
}