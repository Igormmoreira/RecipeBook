using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class RecipeIngredient
    {
        public int Id { get; set; }
        public Ingredient Ingredient { get; set; }
        public Amount Amount { get; set; }
        public Variety Variety { get; set; } // Verificar necessidade

        public RecipeIngredient() { }

        public RecipeIngredient(int id, Ingredient ingredient, Amount amount, Variety variety)
        {
            Id = id;
            Ingredient = ingredient;
            Amount = amount;
            Variety = variety;
        }
    }
}
