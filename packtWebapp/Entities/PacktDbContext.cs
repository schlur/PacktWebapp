﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace packtWebapp.Entities
{
    public class PacktDbContext : DbContext
    {
        public PacktDbContext(DbContextOptions<PacktDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
