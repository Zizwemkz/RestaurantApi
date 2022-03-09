using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Migrations;
using System;


namespace Restaurant.Data.Models
{
    public class RestaurantDBContext : DbContext
    {
        public RestaurantDBContext()
        {
        }

        public RestaurantDBContext(DbContextOptions<RestaurantDBContext> options)
        : base(options)
        {
        }


        public virtual DbSet<RestaurantDetails> RestaurantDetails { get; set; }
        public virtual DbSet<Waiter> Waiter { get; set; }
        public virtual DbSet<RestaurantPhonebook> RestaurantPhonebook { get; set; }
    }
}
