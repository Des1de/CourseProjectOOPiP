
using System.Text.Json;


namespace MyFood.Model
{
    public class Cart
    {
        static string _path = FileSystem.Current.CacheDirectory;
        static string _fullPath = Path.Combine(_path, "CartData.json");

        static List<Dish> _dishes;
        static List<Dish> ReadDishes()
        {
            List<Dish> dishes;
            using (FileStream fs = new(_fullPath, FileMode.OpenOrCreate))
            {
                try
                {
                    dishes = JsonSerializer.Deserialize<List<Dish>>(fs);
                }
                catch (Exception)
                {
                    dishes = new List<Dish>();
                }
            }
            foreach (Dish dsh in dishes)
            {
                dsh.ProductImage = ImageSource.FromFile(dsh.ImageString);
            }
            return dishes;
        }
        static async Task WriteDishes(List<Dish> dishes)
        {
            using (FileStream fs = new(_fullPath, FileMode.Create))
            {
                await JsonSerializer.SerializeAsync<List<Dish>>(fs, dishes);
            }
        }
        static Cart()
        {
            _dishes = ReadDishes();
        }
        public static List<Dish> GetCartList()
        {
            return _dishes;
        }
        
        public async static void ClearCart()
        {
            _dishes.Clear();
            await WriteDishes(_dishes);
        }

        public async static Task<List<Dish>> AddDish(Dish dish)
        {

            _dishes.Add(dish);
            
            await WriteDishes(_dishes);
            return _dishes;
        }
        public async static Task<List<Dish>> RemoveDish(Dish dish)
        {
            await Task.Delay(1);
            Dish tempDish = _dishes.Find(pr => pr.Id == dish.Id);
            _dishes.Remove(tempDish);
            await WriteDishes(_dishes);
            return _dishes;
        }
      

    }
}

