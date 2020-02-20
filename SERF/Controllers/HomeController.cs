using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SERF.Models;

namespace SERF.Controllers
{
    public class HomeController : Controller
    {
        public FormPageContext db = new FormPageContext();

        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/FormPage1
        public ActionResult FormPage1()
        {
            return View();
        }

        // POST: Home/FormPage1
        [HttpPost]
        public ActionResult FormPage1(FormCollection collection)
        {

            try
            {

                //Method 1: Using Component Name  

                ViewData["InsurerRole"] = collection["InsurerRole"];
                ViewData["NameInsured"] = collection["NameInsured"];
                ViewData["Dba"] = collection["Dba"];
                ViewData["MailingAddress"] = collection["MailingAddress"];
                ViewData["City"] = collection["City"];
                ViewData["State"] = collection["State"];
                ViewData["Zipcode"] = collection["Zipcode"];
                ViewData["ContactPerson"] = collection["ContactPerson"];
                ViewData["Email"] = collection["Email"];
                ViewData["HomeNumber"] = collection["HomeNumber"];
                ViewData["BusinessNumber"] = collection["BusinessNumber"];
                ViewData["Fax"] = collection["Fax"];
                ViewData["Website"] = collection["Website"];

                using (db)
                {

                    var formPage1 = new FormPage1();
                    formPage1.InsurerRole = collection["InsurerRole"];
                    formPage1.NameInsured = collection["NameInsured"];
                    formPage1.Dba = collection["Dba"];
                    formPage1.MailingAddress = collection["MailingAddress"];
                    formPage1.City = collection["City"];
                    formPage1.State = collection["State"];
                    formPage1.Zipcode = collection["Zipcode"];
                    formPage1.ContactPerson = collection["ContactPerson"];
                    formPage1.Email = collection["Email"];
                    formPage1.HomeNumber = collection["HomeNumber"];
                    formPage1.BusinessNumber = collection["BusinessNumber"];
                    formPage1.Fax = collection["Fax"];
                    formPage1.Website = collection["Website"];

                    db.PageOne.Add(formPage1);
                    db.SaveChanges();

                    return Redirect("FormPage2");
                }

            }
            catch
            {
                return View("Index");
            }
        }
        // GET: Home/FormPage2
        public ActionResult FormPage2()
        {
            return View();
        }

        // POST: Home/FormPage2
        [HttpPost]
        public ActionResult FormPage2(FormCollection collection)
        {

            try
            {
                //Method 1: Using Component Name  

                ViewData["EventName"] = collection["EventName"];
                ViewData["Date"] = collection["Date"];
                ViewData["BegTime"] = collection["BegTime"];
                ViewData["EndTime"] = collection["EndTime"];
                ViewData["AttendenceCount"] = collection["AttendenceCount"];
                ViewData["AlcoholBeverages"] = collection["AlcoholBeverages"];
                ViewData["EventDetails"] = collection["EventDetails"];
                ViewData["NamedInsuredRole"] = collection["NamedInsuredRole"];
                ViewData["EventPrivacy"] = collection["EventPrivacy"];
                ViewData["AdmissionCharge"] = collection["AdmissionCharge"];
                ViewData["Donation"] = collection["Donation"];
                ViewData["Seating"] = collection["Seating"];
                ViewData["Security"] = collection["Security"];
                ViewData["FirstAide"] = collection["FirstAide"];
                ViewData["Ada"] = collection["Ada"];
                ViewData["Advertisement"] = collection["Advertisement"];
                ViewData["Alcohol"] = collection["Alcohol"];
                ViewData["RecreationalActivity"] = collection["RecreationalActivity"];
                ViewData["Music"] = collection["Music"];
                ViewData["Activities"] = collection["Activities"];

                using (db)
                {

                    var formPage2 = new FormPage2();
                    formPage2.EventName = collection["EventName"];
                    formPage2.NamedInsuredRole = collection["NamedInsuredRole"];
                    formPage2.EventPrivacy = collection["EventPrivacy"];
                    formPage2.AdmissionCharge = collection["AdmissionCharge"];
                    formPage2.Donation = collection["Donation"];
                    formPage2.Seating = collection["Seating"];
                    formPage2.Security = collection["Security"];
                    formPage2.FirstAide = collection["FirstAide"];
                    formPage2.Ada = collection["Ada"];
                    formPage2.Advertisement = collection["Advertisment"];
                    formPage2.Alcohol = collection["Alcohol"];
                    formPage2.RecreationalActivity = collection["RecreationalActivity"];
                    formPage2.Music = collection["Music"];
                    formPage2.Activities = collection["Activities"];

                    db.PageTwo.Add(formPage2);
                    db.SaveChanges();
                }

                return View("Index");
            }

            catch (FormatException e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return View();
            }
        }

        // GET: Home/EventDate
        public ActionResult EventDate()
        {
            return View();
        }

        // POST: Home/EventDate
        [HttpPost]
        public ActionResult EventDate(FormCollection collection)
        {
            try
            {
                ViewData["Date"] = collection["Date"];
                ViewData["BegTime"] = collection["BegTime"];
                ViewData["EndTime"] = collection["EndTime"];
                ViewData["AttendenceCount"] = collection["AttendenceCount"];
                ViewData["AlcoholBeverages"] = collection["AlcoholBeverages"];
                ViewData["EventDetails"] = collection["EventDetails"];
                using (db)
                {

                    var eventDate = new EventDate();
                    
                    eventDate.Date = collection["Date"];
                    eventDate.BegTime = collection["BegTime"];
                    eventDate.EndTime = collection["EndTime"];
                    eventDate.AttendenceCount = collection["AttendenceCount"];
                    eventDate.AlcoholBeverages = collection["AlcoholBeverages"];
                    eventDate.EventDetails = collection["EventDetails"];

                    db.EventDates.Add(eventDate);
                    db.SaveChanges();
                }

                return View("FormPage3");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/FormPage3
        public ActionResult FormPage3()
        {
            return View();
        }

        // POST: Home/FormPage3
        [HttpPost]
        public ActionResult FormPage3(FormCollection collection)
        {
            return View();
        }
    }
}