#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using W21_Assignment.Models;

public class DBContext : IdentityDbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public DbSet<W21_Assignment.Models.Menu> Menu { get; set; }

    public DbSet<W21_Assignment.Models.Coffee> Coffee { get; set; }

    public DbSet<W21_Assignment.Models.SiteUser> SiteUser { get; set; }
}
