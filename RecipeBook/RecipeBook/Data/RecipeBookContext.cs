using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeBook.Models;

namespace RecipeBook.Data
{
    public class RecipeBookContext : DbContext
    {
        public RecipeBookContext (DbContextOptions<RecipeBookContext> options)
            : base(options)
        {
        }

        public DbSet<RecipeBook.Models.Recipe> Recipe { get; set; }

        public DbSet<RecipeBook.Models.Amount> Amount { get; set; }

        public DbSet<RecipeBook.Models.Ingredient> Ingredient { get; set; }

        public DbSet<RecipeBook.Models.RecipeIngredient> RecipeIngredient { get; set; }

        public DbSet<RecipeBook.Models.Variety> Variety { get; set; }
    }
}
