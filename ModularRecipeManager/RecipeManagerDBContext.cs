using Microsoft.EntityFrameworkCore;
using ModularRecipeManager.Models;

namespace ModularRecipeManager
{
    public class RecipeManagerDBContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
    }
}