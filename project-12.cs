string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (var id in orderIDs)
{   
    if (id.StartsWith("B"))
    {
        Console.WriteLine($"This order id {id} is potentially a fraud, take care!");
    }
    else
    {
        Console.WriteLine("This order is safe.");
    }
}
