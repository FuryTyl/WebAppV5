using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppV5.DAL.Entities;

namespace WebAppV5.Controllers
{
    public class ProductController : Controller
    {
        List<Dish> _dishes;
        List<DishGroup> _dishGroups;
        public ProductController()
        {
            SetupData();
        }
        public IActionResult Index()
        {
            return View(_dishes);
        }
        /// <summary>
        /// Инициализация списков
        /// </summary>
        private void SetupData()
        {
            _dishGroups = new List<DishGroup>
            {
            new DishGroup {DishGroupId=1, GroupName="Стартеры"},
            new DishGroup {DishGroupId=2, GroupName="Салаты"},
            new DishGroup {DishGroupId=3, GroupName="Супы"},
            new DishGroup {DishGroupId=4, GroupName="Основные блюда"},
            new DishGroup {DishGroupId=5, GroupName="Напитки"},
            new DishGroup {DishGroupId=6, GroupName="Десерты"}
            };

            _dishes = new List<Dish>
            {
            new Dish {DishId = 1, DishName="Пивной набор",
            Description="Много сала, вкусный",
            Calories =500, DishGroupId=1, Image="1.jpg" },

            new Dish { DishId = 2, DishName="Кофе с булочкой",
            Description="Горький, сладкая булочка",
            Calories =300, DishGroupId=6, Image="2.jpg" },

            new Dish { DishId = 3, DishName="Яичница с тостами",
            Description="Хлеб - 40%, Яйцо - 60%",
            Calories =400, DishGroupId=4, Image="3.jpg" },
            };
        }
    }
}
