using ElectronicMedicalRecord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicMedicalRecord.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Verify(Employed employed)
        {
            try
            {

                using (var db = new ElectronicMedicalRecord_DbContext())
                {
                    var query = (from tbl_employed in db.Employeds
                                 where employed.Username == tbl_employed.Username && employed.Password == tbl_employed.Password
                                 select new
                                 {
                                     tbl_employed.Username,
                                     tbl_employed.Password
                                 }).ToList();
                    
                }
                
                return View("IndexPage");
            }
            catch(Exception)
            {
                return View("LogInError");
            }
        }
    }
}