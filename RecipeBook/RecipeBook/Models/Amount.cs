using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeBook.Enums;

namespace RecipeBook.Models
{
    public class Amount
    {
        public int Id { get; set; }
        public AmountUnt Unit { get; set; }
        public int Quantity { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>(); // Verificar necessidade

        public Amount() { }

        public Amount(int id, AmountUnt unit, int quantity)
        {
            Id = id;
            Unit = unit;
            Quantity = quantity;
        }
    }
}
