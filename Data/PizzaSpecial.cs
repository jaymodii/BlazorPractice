


public class PizzaSpecial
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal BasePrice { get; set; }  

    public string Description { get; set; }

    //public int DefaultSize { get; set; } = 3;
    public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
}