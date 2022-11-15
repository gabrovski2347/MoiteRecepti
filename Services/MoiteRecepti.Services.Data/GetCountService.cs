using MoiteRecepti.Data.Common.Repositories;
using MoiteRecepti.Data.Models;
using MoiteRecepti.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoiteRecepti.Services.Data
{
    public class GetCountService : IGetCountService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;
        private readonly IRepository<Image> imagesRepository;
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRepository;

        public GetCountService(IDeletableEntityRepository<Category> categoriesRepository,
            IRepository<Image> imagesRepository,
            IDeletableEntityRepository<Recipe> recipesRepository,
            IDeletableEntityRepository<Ingredient> ingredientsRepository)
        {
            this.categoriesRepository = categoriesRepository;
            this.imagesRepository = imagesRepository;
            this.recipesRepository = recipesRepository;
            this.ingredientsRepository = ingredientsRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel()
            {
                CategoriesCount = this.categoriesRepository.All().Count(),
                ImagesCount = this.imagesRepository.All().Count(),
                IngredientsCount = this.ingredientsRepository.All().Count(),
                RecipesCount = this.recipesRepository.All().Count(),
            };

            return data;
        }
    }
}
