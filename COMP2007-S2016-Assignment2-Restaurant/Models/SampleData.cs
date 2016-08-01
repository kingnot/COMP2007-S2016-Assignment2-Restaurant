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
                new Foodtype { Name = "Appetizers", FoodtypePicUrl = "/Assets/images/appetizers.png"},
                new Foodtype { Name = "Rolls", FoodtypePicUrl = "/Assets/images/rolls.png"},
                new Foodtype { Name = "Sushi", FoodtypePicUrl = "/Assets/images/sushi.png"},
                new Foodtype { Name = "Fried Rice", FoodtypePicUrl = "/Assets/images/fried_rice.png"}
            };

            new List<Fooditem>
            {
                new Fooditem { Name = "Cheese Wonton", Foodtype = foodtypes.Single(g => g.Name == "Appetizers"), Price = 4.95M, FooditemThumbnailUrl = "/Assets/images/cheese_wonton.png", FooditemPicUrl = "/Assets/images/hd/cheese_wonton.jpg", ShortDescription = "8 pieces", DetailedDescription= "Deep Fried Wonton with Cheese Inside"},
                new Fooditem { Name = "Gyoza", Foodtype = foodtypes.Single(g => g.Name == "Appetizers"), Price = 4.95M, FooditemThumbnailUrl = "/Assets/images/gyoza.png", FooditemPicUrl = "/Assets/images/hd/gyoza.jpg", ShortDescription = "6 pieces", DetailedDescription= "Fried Pork Dumpling"},
                new Fooditem { Name = "Shrimp Tempura", Foodtype = foodtypes.Single(g => g.Name == "Appetizers"), Price = 6.95M, FooditemThumbnailUrl = "/Assets/images/shrimp_tempura.png", FooditemPicUrl = "/Assets/images/hd/shrimp_tempura.jpg", ShortDescription = "5 pieces", DetailedDescription= "Lightly battered Deep Fried Shrimp"},
                new Fooditem { Name = "Chicken Teriyaki", Foodtype = foodtypes.Single(g => g.Name == "Appetizers"), Price = 8.95M, FooditemThumbnailUrl = "/Assets/images/chicken_teriyaki.png", FooditemPicUrl = "/Assets/images/hd/chicken_teriyaki.png", ShortDescription = "2 pieces", DetailedDescription= "Chicken with Teriyaki Sauce"},
                new Fooditem { Name = "California Roll", Foodtype = foodtypes.Single(g => g.Name == "Rolls"), Price = 4.95M, FooditemThumbnailUrl = "/Assets/images/california_roll.png", FooditemPicUrl = "/Assets/images/hd/california_roll.jpg", ShortDescription = "8 pieces", DetailedDescription= "Salmon, Avocado, Cucumber"},
                new Fooditem { Name = "AK-47", Foodtype = foodtypes.Single(g => g.Name == "Rolls"), Price = 8.95M, FooditemThumbnailUrl = "/Assets/images/ak47.png", FooditemPicUrl = "/Assets/images/hd/ak47.jpg", ShortDescription = "8 pieces", DetailedDescription= "Deep Fried Roll with Salmon, Crabmeat, Avocado Inside"},
                new Fooditem { Name = "Red Dragon", Foodtype = foodtypes.Single(g => g.Name == "Rolls"), Price = 7.95M, FooditemThumbnailUrl = "/Assets/images/red_dragon.png", FooditemPicUrl = "/Assets/images/hd/red_dragon.jpg", ShortDescription = "8 pieces", DetailedDescription= "California Roll with Salmon on top"},
                new Fooditem { Name = "Avocado Cucumber Roll", Foodtype = foodtypes.Single(g => g.Name == "Rolls"), Price = 4.45M, FooditemThumbnailUrl = "/Assets/images/avocado_cucumber_roll.png", FooditemPicUrl = "/Assets/images/hd/avocado_cucumber_roll.jpg", ShortDescription = "8 pieces, Vegetarian", DetailedDescription= "Avocado, Cucumber"},
                new Fooditem { Name = "Salmon Sushi", Foodtype = foodtypes.Single(g => g.Name == "Sushi"), Price = 5.50M, FooditemThumbnailUrl = "/Assets/images/salmon_sushi.png", FooditemPicUrl = "/Assets/images/hd/salmon_sushi.jpg", ShortDescription = "6 pieces", DetailedDescription= "Salmon on top of Rice ball"},
                new Fooditem { Name = "Tuna Sushi", Foodtype = foodtypes.Single(g => g.Name == "Sushi"), Price = 5.50M, FooditemThumbnailUrl = "/Assets/images/tuna_sushi.png", FooditemPicUrl = "/Assets/images/hd/tuna_sushi.jpg", ShortDescription = "6 pieces", DetailedDescription= "Tuna on top of Rice ball"},
                new Fooditem { Name = "Eel Sushi", Foodtype = foodtypes.Single(g => g.Name == "Sushi"), Price = 5.50M, FooditemThumbnailUrl = "/Assets/images/eel_sushi.png", FooditemPicUrl = "/Assets/images/hd/eel_sushi.jpg", ShortDescription = "6 pieces", DetailedDescription= "Eel on top of Rice ball"},
                new Fooditem { Name = "Crab Sushi", Foodtype = foodtypes.Single(g => g.Name == "Sushi"), Price = 4.95M, FooditemThumbnailUrl = "/Assets/images/crab_sushi.png", FooditemPicUrl = "/Assets/images/hd/crab_sushi.jpg", ShortDescription = "6 pieces", DetailedDescription= "Crab on top of Rice ball"},
                new Fooditem { Name = "Eel Fried Rice", Foodtype = foodtypes.Single(g => g.Name == "Fried Rice"), Price = 9.95M, FooditemThumbnailUrl = "/Assets/images/eel_fried_rice.png", FooditemPicUrl = "/Assets/images/hd/eel_fried_rice.jpg", ShortDescription = "One set", DetailedDescription= "Fried Rice with Eel, Carrot, Peas"},
                new Fooditem { Name = "Salmon Fried Rice", Foodtype = foodtypes.Single(g => g.Name == "Fried Rice"), Price = 8.95M, FooditemThumbnailUrl = "/Assets/images/salmon_fried_rice.png", FooditemPicUrl = "/Assets/images/hd/salmon_fried_rice.jpg", ShortDescription = "One set", DetailedDescription= "Fried Rice with Salmon, Carrot, Peas"},
                new Fooditem { Name = "Mixed Vegetable Fried Rice", Foodtype = foodtypes.Single(g => g.Name == "Fried Rice"), Price = 7.95M, FooditemThumbnailUrl = "/Assets/images/mixed_vegetable_fried_rice.png", FooditemPicUrl = "/Assets/images/hd/mixed_vegetable_fried_rice.jpg", ShortDescription = "One set, Vegetarian", DetailedDescription= "Fried Rice with Mushroom, Carrot, Peas"},
                new Fooditem { Name = "Seafood Fried Rice", Foodtype = foodtypes.Single(g => g.Name == "Fried Rice"), Price = 8.95M, FooditemThumbnailUrl = "/Assets/images/seafood_fried_rice.png", FooditemPicUrl = "/Assets/images/hd/seafood_fried_rice.jpg", ShortDescription = "One set", DetailedDescription= "Fried Rice with Shrimp, Salmon, Mussel"}
            }.ForEach(a => context.Fooditems.Add(a));

        }
    }
}