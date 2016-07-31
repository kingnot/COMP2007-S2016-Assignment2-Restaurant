/**
 * @file: HomeController.cs
 * @website: Ajiji Sushi
 * @author: Siqian Yu, Fei Wang
 * @date: July 28, 2016
 * @description: This is the Home Controller
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_Assignment2_Restaurant.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /**public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }**/
    }
}