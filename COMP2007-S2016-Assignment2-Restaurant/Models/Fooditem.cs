﻿/**
 * @file: Fooditem.cs
 * @website: Ajiji Sushi
 * @author: Siqian Yu, Fei Wang
 * @date: July 28, 2016
 * @description: This is the Model of Fooditem that has food name, price, description and image
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            this.Name = Name;
        }

        public virtual int FooditemId { get; set; }
        public virtual int FoodtypeId { get; set; }

        [Display(Name = "Food Item")]
        public virtual string Name { get; set; }

        [DataType(DataType.Currency)]
        public virtual decimal Price { get; set; }

        [Display(Name = "Food Picture URL")]
        public virtual string FooditemPicUrl { get; set; }

        [Display(Name = "Food Thumbnail URL")]
        public virtual string FooditemThumbnailUrl { get; set; }
        public virtual string ShortDescription { get; set; }
        public virtual string DetailedDescription { get; set; }
        public virtual Foodtype Foodtype { get; set; }
    }
}