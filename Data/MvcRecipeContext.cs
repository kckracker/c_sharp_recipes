using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recipes.Models;

    public class MvcRecipeContext : DbContext
    {
        public MvcRecipeContext (DbContextOptions<MvcRecipeContext> options)
            : base(options)
    {
        }

        public DbSet<Recipes.Models.Recipe> Recipe { get; set; }
    }
