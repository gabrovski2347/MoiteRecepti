using MoiteRecepti.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoiteRecepti.Data.Models
{
    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            Recipes = new HashSet<Recipe>();
        }
        public string Name { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}
