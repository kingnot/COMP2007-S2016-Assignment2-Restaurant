namespace COMP2007_S2016_Assignment2_Restaurant.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuContext : DbContext
    {
        public MenuContext()
            : base("name=MenuConnection")
        {
        }

        public virtual DbSet<Foodtype> Foodtypes { get; set; }
        public virtual DbSet<Fooditem> Fooditems { get; set; }
    }
}
