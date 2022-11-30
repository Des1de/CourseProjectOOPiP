
using MyFood.Model;

namespace MyFood.Services
{
    public class CartService 
    {
        public List<Dish> GetCartList()
        {
            return Cart.GetCartList();
        }
        public async Task<List<Dish>> AddProduct(Dish dish)
        {
            List<Dish> tempList = await Cart.AddDish(dish);
            CartChanged?.Invoke();
            return tempList;
        }
        public async Task<List<Dish>> RemoveProduct(Dish dish)
        {
            List<Dish> tempList = await Cart.RemoveDish(dish);
            CartChanged.Invoke();
            return tempList;
        }
        public void ClearCart()
        {
            Cart.ClearCart();
            CartChanged?.Invoke();
        }

        public event CartUpdated CartChanged;

        public delegate void CartUpdated();
    }
}
