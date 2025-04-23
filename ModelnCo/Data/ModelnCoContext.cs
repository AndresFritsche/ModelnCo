using System;
using ModelnCoAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ModelnCoAPI.Data;

public class ModelnCoContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Category> Categories { get;set; }
    
    public DbSet<Payment> Payments { get;set; }
}
