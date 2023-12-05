

namespace BlazorApp1.Data
{
    public class SeedData
    {
        public static void Initialize(PizzaStoreContext db)
        {
            var specials = new PizzaSpecial[]
            {
            new PizzaSpecial()
            {
                Name = "Basic Cheese Pizza",
                Description = "It's cheesy and delicious. Why wouldn't you want one?",
                BasePrice = 9.99m,
               
            },
            new PizzaSpecial()
            {
                Id = 2,
                Name = "The Baconatorizor",
                Description = "It has EVERY kind of bacon",
                BasePrice = 11.99m,
               
            },
            new PizzaSpecial()
            {
                Id = 3,
                Name = "Classic pepperoni",
                Description = "It's the pizza you grew up with, but Blazing hot!",
                BasePrice = 10.50m,
               
            },
            new PizzaSpecial()
            {
                Id = 4,
                Name = "Bhakhari Pizza",
                Description = "Spicy gujarati styled pizza to warm up you",
                BasePrice = 12.75m,
         
            },
            new PizzaSpecial()
            {
                Id = 5,
                Name = "Veg Lovers",
                Description = "It has all vegetables. Isn't that obvious?",
                BasePrice = 11.00m,
              
            },
            new PizzaSpecial()
            {
                Id = 7,
                Name = "Veggie Delight",
                Description = "It's like salad, but on a pizza",
                BasePrice = 11.50m,
               
            },
            new PizzaSpecial()
            {
                Id = 8,
                Name = "Margherita",
                Description = "Traditional Italian pizza with tomatoes and basil",
                BasePrice = 9.99m,
               
            },
            };
            db.PizzaSpecials.AddRange(specials);
            db.SaveChanges();
        }
    }
}
