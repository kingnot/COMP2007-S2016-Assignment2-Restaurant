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
                new Foodtype { Name = "Appetizers", FoodtypePicUrl = "/Content/images/placeholder.gif"},
                new Foodtype { Name = "Rolls", FoodtypePicUrl = "/Content/images/placeholder.gif"},
                new Foodtype { Name = "Sushi", FoodtypePicUrl = "/Content/images/placeholder.gif"},
                new Foodtype { Name = "Fried Rice", FoodtypePicUrl = "/Content/images/placeholder.gif"}
            };

            new List<Fooditem>
            {
                new Fooditem { Name = "Cheese Wonton", Foodtype = foodtypes.Single(g => g.Name == "Appetizers"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Gyoza", Foodtype = foodtypes.Single(g => g.Name == "Appetizers"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Shrimp Tempura", Foodtype = foodtypes.Single(g => g.Name == "Appetizers"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Chicken Teriyaki", Foodtype = foodtypes.Single(g => g.Name == "Appetizers"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "California Roll", Foodtype = foodtypes.Single(g => g.Name == "Rolls"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "AK-47", Foodtype = foodtypes.Single(g => g.Name == "Rolls"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Red Dragon", Foodtype = foodtypes.Single(g => g.Name == "Rolls"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Avocado Cucumber Roll", Foodtype = foodtypes.Single(g => g.Name == "Rolls"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Salmon Sushi", Foodtype = foodtypes.Single(g => g.Name == "Sushi"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Tuna Sushi", Foodtype = foodtypes.Single(g => g.Name == "Sushi"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Eel Sushi", Foodtype = foodtypes.Single(g => g.Name == "Sushi"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Crab Sushi", Foodtype = foodtypes.Single(g => g.Name == "Sushi"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Eel Fried Rice", Foodtype = foodtypes.Single(g => g.Name == "Fried Rice"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Salmon Fried Rice", Foodtype = foodtypes.Single(g => g.Name == "Fried Rice"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Mixed Vegetable Fried Rice", Foodtype = foodtypes.Single(g => g.Name == "Fried Rice"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "Seafood Fried Rice", Foodtype = foodtypes.Single(g => g.Name == "Fried Rice"), Price = 8.99M, FooditemPicUrl = "/Content/images/placeholder.gif", ShortDescription = "food", DetailedDescription= "Salmon, Avocado, Cucumber"}
            }.ForEach(a => context.Fooditems.Add(a));

        }
    }
}