using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LuuThiPhuong345.Models;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<LuuThiPhuong345.Models.PersonLTP345> PersonLTP345 { get; set; }
    }
