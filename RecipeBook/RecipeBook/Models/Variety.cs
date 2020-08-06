using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Variety
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
        public Recipe Recipe { get; set; } // Verificar necessidade

        public Variety() { }

        public Variety(int id, string name, Recipe recipe)
        {
            Id = id;
            Name = name;
            Recipe = recipe;
        }

        public void AddRecipeIngredient(RecipeIngredient recipeIngredient)
        {
            RecipeIngredients.Add(recipeIngredient);
        }

        public void RemoveRecipeIngredient(RecipeIngredient recipeIngredient)
        {
            RecipeIngredients.Remove(recipeIngredient);
        }
    }
}
