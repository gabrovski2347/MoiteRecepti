using MoiteRecepti.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoiteRecepti.Data.Models
{
    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public string AddedByUserId { get; set; }
        public ApplicationUser AddedByUser { get; set; }

        public string Extension { get; set; }
    }
}
