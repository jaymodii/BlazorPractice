namespace BlazorApp1.Data   
{
    public class PizzaData
    {
        public int PizzaId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }

        public int MinimumSize { get; set; } = 1;

        public int MaximumSize { get; set; } = 5;

        public int Size { get; set; } = 3;

        public string GetFormattedTotalPrice() => (Price * Size).ToString();

        public PizzaSpecial PizzaSpecial {get; set;}
    }
}
