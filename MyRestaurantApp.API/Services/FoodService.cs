namespace MyRestaurantApp.API.Services;

public class FoodService
{
    public object[] GetFoods()
    {
        //this is where we will get the data from the database, but for now we are just returning a hardcoded list
        return new[]
        //this is a hardcoded list of foods. In a real application, this data would come from a database.
        {
            new { Id = 1, Name = "Momo", Price = 150 },
            new { Id = 2, Name = "Pizza", Price = 300 },
            new { Id = 3, Name = "Burger", Price = 250 }
        };
    }
}