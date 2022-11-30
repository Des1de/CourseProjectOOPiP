using MyFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFood.Services
{
    public class DishService
    {
        public List<Dish> GetProducts()
        {
            return TempServer.GetDishes();
        }
        public async Task<List<Dish>> GetProductsAsync()
        {
            return await TempServer.GetDishesAsync();
        }
    }
}
