using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Variety> Varieties { get; set; } = new List<Variety>();

        public Recipe() { }

        public Recipe(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddVariety(Variety variety)
        {
            Varieties.Add(variety);
        }

        public void RemoveVariety(Variety variety)
        {
            Varieties.Remove(variety);
        }
    }
}
