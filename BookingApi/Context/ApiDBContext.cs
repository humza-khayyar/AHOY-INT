using BookingApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.Context
{

    public class ApiDBContext : DbContext
    {

        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options)
        {

        }
        public DbSet<Vehicle> dbb_Vehicles { get; set; }
        public DbSet<Customers> dbb_Customer { get; set; }
        public DbSet<OrderDetails> dbb_orderDetails { get; set; }
        public DbSet<Orders> dbb_Orders { get; set; }

    }
}
