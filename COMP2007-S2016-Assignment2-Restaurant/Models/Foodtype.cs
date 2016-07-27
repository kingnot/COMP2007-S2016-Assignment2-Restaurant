using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_Assignment2_Restaurant.Models
{
    public class Foodtype
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Foodtype()
        {

        }

        /// <summary>
        /// This is the constructor takes one parameter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Foodtype(string Name)
        {
            this.Name = Name;
        }

        public virtual int FoodtypeId { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Fooditem> Fooditems { get; set; }
    }

}