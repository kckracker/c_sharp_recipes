using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Recipes.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcRecipeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcRecipeContext>>()))
            {
                // Look for any movies.
                if (context.Recipe.Any())
                {
                    return;   // DB has been seeded
                }

                context.Recipe.AddRange(
                    new Recipes.Models.Recipe
                    {
                        Title = "Chicken Wings",
                        Ingredients = "1 pack chicken wings, 1/2 cup flour, 1 tsp salt, 1 tsp black pepper, 3 cups vegetable oil",
                        Instructions = "Rinse and dry wings with paper towels. Mix salt and pepper into flour for base coating. Coat chicken wings liberally with flour mixture. Heat oil on medium high for approximately 5 minutes in large pot. Carefully place chicken wings into pot and cook through to internal temp of 165 degrees.",
                        Cook_Time = 35
                    },
                    new Recipes.Models.Recipe
                    {
                        Title = "Morning Waffles",
                        Ingredients = "1 pack Ego waffles",
                        Instructions = "Carefully remove waffle from packaging. Wrestle waffle free from frozen compatriots. Place in toaster for 1 - 2 minutes.",
                        Cook_Time = 2
                    },
                    new Recipes.Models.Recipe
                    {
                        Title = "PB & J",
                        Ingredients = "2 Tbsp peanut butter, 2 Tbsp favorite jam, 2 slices breadds",
                        Instructions = "Place slices of bread side by side. Flip coin to decide which slice gets peanut butter and which gets jam. Liberally apply each to respective bread slice. Gracefully place one slice onto second slice.",
                        Cook_Time = 4
                    }
                );
                context.SaveChanges();
            }
        }
    }
}