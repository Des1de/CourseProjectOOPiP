namespace MyFood.Model
{
    public class Dish
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public string ImageString { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public ImageSource ProductImage { get; set; }

        public Dish(int id, string name, double price, string description, string imageString)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            ImageString = imageString;
            ProductImage = ImageSource.FromFile(imageString);
        }
    }
}
