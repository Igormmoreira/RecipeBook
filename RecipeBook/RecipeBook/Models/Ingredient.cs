using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>(); // Verificar necessidade

        public Ingredient() { }

        public Ingredient(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
