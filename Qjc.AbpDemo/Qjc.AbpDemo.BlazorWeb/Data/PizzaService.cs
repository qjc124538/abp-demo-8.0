namespace Qjc.AbpDemo.BlazorWeb.Data
{
    public class PizzaService
    {
        public async Task<List<PizzaSpecial>> GetPizzasAsync()
        {
            List<PizzaSpecial> pizzaSpecials = new List<PizzaSpecial>
            {
                new PizzaSpecial{ Name = "The Baconatorizor", Price = 11.99M, Description = "It has EVERY kind of bacon" }
            };
            return await Task.FromResult(pizzaSpecials);
        }
    }
}
