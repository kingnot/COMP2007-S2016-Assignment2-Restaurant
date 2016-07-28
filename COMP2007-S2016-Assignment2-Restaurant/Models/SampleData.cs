using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace COMP2007_S2016_Assignment2_Restaurant.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<MenuContext>
    {
        protected override void Seed(MenuContext context)
        {
            var foodtypes = new List<Foodtype>
            {
                new Foodtype { Name = "Rock" },
                new Foodtype { Name = "Jazz" },
                new Foodtype { Name = "Metal" },
                new Foodtype { Name = "Alternative" },
                new Foodtype { Name = "Disco" },
            };


           
        }
    }
}