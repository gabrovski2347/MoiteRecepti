using MoiteRecepti.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoiteRecepti.Data.Models
{
    public class Recipe : BaseDeletableModel<int>
    {
        public Recipe()
        {
            Ingredients = new HashSet<RecipeIngredient>();
            Images = new HashSet<Image>();
        }
        public string Name { get; set; }

        public string Instructions { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public int PortionsCount { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public ICollection<RecipeIngredient> Ingredients { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
