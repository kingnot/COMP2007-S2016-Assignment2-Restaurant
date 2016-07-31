/**
 * @file: MenuController.cs
 * @website: Ajiji Sushi
 * @author: Siqian Yu, Fei Wang
 * @date: July 24, 2016
 * @description: This is the Menu Controller
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_S2016_Assignment2_Restaurant.Models;

namespace COMP2007_S2016_Assignment2_Restaurant.Controllers
{
    public class MenuController : Controller
    {
        MenuContext menuDB = new MenuContext();
        
        //
        // GET: /Menu/
        
        public ActionResult Index()
        {
            List<Foodtype> foodtypes = menuDB.Foodtypes.ToList();

            return View(foodtypes);
        }

        //
        // GET: /Menu/Browse?foodtype=Appetizer
        public ActionResult Browse(string foodtype = "Appetizer")
        {
            // Retrieve Foodtype and its Associated Fooditem from database
            Foodtype typeModel = menuDB.Foodtypes.Include("Fooditems").Single(g => g.Name == foodtype);

            return View(typeModel);
        }
        //
        // GET: /Menu/Details/1
        public ActionResult Details(int id = 1)
        {
            Fooditem item = menuDB.Fooditems.Find(id);

            return View(item);
        }

    }
}