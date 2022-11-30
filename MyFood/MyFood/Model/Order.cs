
namespace MyFood.Model
{
    public class Order
    {
        public List<Dish> Dishes { get; private set; }
        public int OrderId { get; private set; }
        public DateTime OrderTime { get; private set; }
        public string UserName { get; private set; }
        public double TotalPrice { get; private set; }

        public Order(List<Dish> dishes, DateTime orderTime, string userName, double totalPrice, int orderId)
        {
            Dishes = dishes;
            OrderTime = orderTime;
            UserName = userName;
            TotalPrice = totalPrice;
            OrderId = orderId;
        }
    }
}
