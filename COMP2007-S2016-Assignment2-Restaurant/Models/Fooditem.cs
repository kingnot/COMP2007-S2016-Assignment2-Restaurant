using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_Assignment2_Restaurant.Models
{
    public class Fooditem
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Fooditem()
        {

        }

        /// <summary>
        /// This is the constructor takes one parameter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Fooditem(string Name)
        {

        }

        public virtual int FooditemId { get; set; }
        public virtual int FoodtypeId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual Foodtype Foodtype { get; set; }
    }
}