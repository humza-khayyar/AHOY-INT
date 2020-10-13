using AdminApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Context
{
    public class ApiDBContext : DbContext
    {

        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options)
        {

        }
        public DbSet<Vehicles> dbb_Vehicles { get; set; }
        public DbSet<Customer> dbb_Customer { get; set; }
    }
}
