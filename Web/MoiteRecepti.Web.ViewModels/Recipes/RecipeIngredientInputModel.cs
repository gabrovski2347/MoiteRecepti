﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoiteRecepti.Web.ViewModels.Recipes
{
    public class RecipeIngredientInputModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        public string Quantity { get; set; }
    }
}
