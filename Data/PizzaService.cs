namespace BlazingPizza.Data
{
    public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            // Call your data access technology here
            var pl = new Pizza[] { new() { Name = "a", Description = "aaa", PizzaId = 1, Price = 1, Vegan = false, Vegetarian = false } };
            return Task<Pizza[]>.FromResult(pl); ;
        }
    }
}
