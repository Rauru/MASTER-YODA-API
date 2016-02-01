using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MasterYodaAPI.DataAdapterLayer.Interfaces;

namespace MasterYodaAPI.ApplicationLayer.Controller
{
    public class HomeController : System.Web.Mvc.Controller
    {
        // GET: Home
        public String Index(string correo)
        {
            var DA = new UserInterfaces();
            DA.addUser(correo);
            return "HELLO WORLD";
        }
    }
}