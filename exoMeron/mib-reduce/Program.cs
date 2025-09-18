
List<Product> products = new()
            {
            new Product() { Location = "1", Provider = "Bornand", Name = "Pommes", Quantity = 20, Unit = "kg", Price = 6.90m },
            new Product() { Location = "1", Provider = "Bornand", Name = "Poires", Quantity = 16, Unit = "kg", Price = 3.50m },
            new Product() { Location = "1", Provider = "Bornand", Name = "Pastèques", Quantity = 14, Unit = "pièce", Price = 6.00m },
            new Product() { Location = "1", Provider = "Bornand", Name = "Melons", Quantity = 5, Unit = "kg", Price = 7.00m },
            new Product() { Location = "2", Provider = "Dumont", Name = "Noix", Quantity = 20, Unit = "sac", Price = 8.60m },
            new Product() { Location = "2", Provider = "Dumont", Name = "Raisin", Quantity = 6, Unit = "kg", Price = 5.60m },
            new Product() { Location = "2", Provider = "Dumont", Name = "Pruneaux", Quantity = 13, Unit = "kg", Price = 8.10m },
            new Product() { Location = "2", Provider = "Dumont", Name = "Myrtilles", Quantity = 12, Unit = "kg", Price = 8.90m },
            new Product() { Location = "2", Provider = "Dumont", Name = "Groseilles", Quantity = 12, Unit = "kg", Price = 5.20m },
            new Product() { Location = "3", Provider = "Vonlanthen", Name = "Pêches", Quantity = 8, Unit = "kg", Price = 8.70m },
            new Product() { Location = "3", Provider = "Vonlanthen", Name = "Haricots", Quantity = 6, Unit = "kg", Price = 6.90m },
            new Product() { Location = "3", Provider = "Vonlanthen", Name = "Courges", Quantity = 18, Unit = "pièce", Price = 4.30m },
            new Product() { Location = "3", Provider = "Vonlanthen", Name = "Tomates", Quantity = 12, Unit = "kg", Price = 9.40m },
            new Product() { Location = "3", Provider = "Vonlanthen", Name = "Pommes", Quantity = 20, Unit = "kg", Price = 3.90m },
            new Product() { Location = "4", Provider = "Barizzi", Name = "Poires", Quantity = 5, Unit = "kg", Price = 6.30m },
            new Product() { Location = "4", Provider = "Barizzi", Name = "Pastèques", Quantity = 6, Unit = "pièce", Price = 2.50m },
            new Product() { Location = "4", Provider = "Barizzi", Name = "Melons", Quantity = 14, Unit = "kg", Price = 4.20m },
            new Product() { Location = "4", Provider = "Barizzi", Name = "Noix", Quantity = 20, Unit = "sac", Price = 7.50m },
            new Product() { Location = "4", Provider = "Barizzi", Name = "Raisin", Quantity = 15, Unit = "kg", Price = 7.20m },
            new Product() { Location = "5", Provider = "Blanc", Name = "Pruneaux", Quantity = 5, Unit = "kg", Price = 9.00m },
            new Product() { Location = "5", Provider = "Blanc", Name = "Myrtilles", Quantity = 18, Unit = "kg", Price = 5.60m },
            new Product() { Location = "5", Provider = "Blanc", Name = "Groseilles", Quantity = 10, Unit = "kg", Price = 2.10m },
            new Product() { Location = "5", Provider = "Blanc", Name = "Pêches", Quantity = 20, Unit = "kg", Price = 6.40m },
            new Product() { Location = "5", Provider = "Blanc", Name = "Haricots", Quantity = 9, Unit = "kg", Price = 2.90m },
            new Product() { Location = "6", Provider = "Repond", Name = "Courges", Quantity = 12, Unit = "pièce", Price = 7.40m },
            new Product() { Location = "6", Provider = "Repond", Name = "Tomates", Quantity = 12, Unit = "kg", Price = 4.20m },
            new Product() { Location = "6", Provider = "Repond", Name = "Pommes", Quantity = 15, Unit = "kg", Price = 6.50m },
            new Product() { Location = "6", Provider = "Repond", Name = "Poires", Quantity = 18, Unit = "kg", Price = 2.40m },
            new Product() { Location = "6", Provider = "Repond", Name = "Pastèques", Quantity = 7, Unit = "pièce", Price = 5.70m },
            new Product() { Location = "7", Provider = "Mancini", Name = "Pêches", Quantity = 10, Unit = "kg", Price = 2.90m },
            new Product() { Location = "7", Provider = "Mancini", Name = "Haricots", Quantity = 11, Unit = "kg", Price = 6.70m },
            new Product() { Location = "7", Provider = "Mancini", Name = "Courges", Quantity = 10, Unit = "pièce", Price = 6.40m },
            new Product() { Location = "7", Provider = "Mancini", Name = "Tomates", Quantity = 13, Unit = "kg", Price = 1.50m },
            new Product() { Location = "7", Provider = "Mancini", Name = "Pommes", Quantity = 14, Unit = "kg", Price = 7.00m },
            new Product() { Location = "8", Provider = "Favre", Name = "Poires", Quantity = 5, Unit = "kg", Price = 8.40m },
            new Product() { Location = "8", Provider = "Favre", Name = "Pastèques", Quantity = 5, Unit = "pièce", Price = 1.70m },
            new Product() { Location = "8", Provider = "Favre", Name = "Haricots", Quantity = 5, Unit = "kg", Price = 3.00m },
            new Product() { Location = "8", Provider = "Favre", Name = "Courges", Quantity = 17, Unit = "pièce", Price = 2.00m },
            new Product() { Location = "8", Provider = "Favre", Name = "Tomates", Quantity = 9, Unit = "kg", Price = 5.20m },
            new Product() { Location = "9", Provider = "Bovay", Name = "Pommes", Quantity = 13, Unit = "kg", Price = 7.70m },
            new Product() { Location = "9", Provider = "Bovay", Name = "Poires", Quantity = 5, Unit = "kg", Price = 3.80m },
            new Product() { Location = "9", Provider = "Bovay", Name = "Pastèques", Quantity = 20, Unit = "pièce", Price = 2.10m },
            new Product() { Location = "9", Provider = "Bovay", Name = "Melons", Quantity = 20, Unit = "kg", Price = 6.40m },
            new Product() { Location = "9", Provider = "Bovay", Name = "Noix", Quantity = 13, Unit = "sac", Price = 8.80m },
            new Product() { Location = "10", Provider = "Cherix", Name = "Raisin", Quantity = 8, Unit = "kg", Price = 7.10m },
            new Product() { Location = "10", Provider = "Cherix", Name = "Pruneaux", Quantity = 19, Unit = "kg", Price = 7.90m },
            new Product() { Location = "10", Provider = "Cherix", Name = "Myrtilles", Quantity = 9, Unit = "kg", Price = 4.20m },
            new Product() { Location = "10", Provider = "Cherix", Name = "Groseilles", Quantity = 10, Unit = "kg", Price = 4.40m },
            new Product() { Location = "10", Provider = "Cherix", Name = "Pêches", Quantity = 9, Unit = "kg", Price = 4.40m },
            new Product() { Location = "11", Provider = "Beaud", Name = "Haricots", Quantity = 19, Unit = "kg", Price = 8.40m },
            new Product() { Location = "11", Provider = "Beaud", Name = "Courges", Quantity = 16, Unit = "pièce", Price = 8.70m },
            new Product() { Location = "11", Provider = "Beaud", Name = "Tomates", Quantity = 18, Unit = "kg", Price = 5.30m },
            new Product() { Location = "11", Provider = "Beaud", Name = "Pommes", Quantity = 8, Unit = "kg", Price = 7.30m },
            new Product() { Location = "11", Provider = "Beaud", Name = "Poires", Quantity = 13, Unit = "kg", Price = 9.20m },
            new Product() { Location = "12", Provider = "Corbaz", Name = "Pastèques", Quantity = 15, Unit = "pièce", Price = 7.40m },
            new Product() { Location = "12", Provider = "Corbaz", Name = "Melons", Quantity = 12, Unit = "kg", Price = 1.60m },
            new Product() { Location = "12", Provider = "Corbaz", Name = "Noix", Quantity = 11, Unit = "sac", Price = 7.50m },
            new Product() { Location = "12", Provider = "Corbaz", Name = "Raisin", Quantity = 16, Unit = "kg", Price = 4.50m },
            new Product() { Location = "12", Provider = "Corbaz", Name = "Pruneaux", Quantity = 20, Unit = "kg", Price = 3.30m },
            new Product() { Location = "13", Provider = "Amaudruz", Name = "Myrtilles", Quantity = 18, Unit = "kg", Price = 5.70m },
            new Product() { Location = "13", Provider = "Amaudruz", Name = "Groseilles", Quantity = 19, Unit = "kg", Price = 8.00m },
            new Product() { Location = "13", Provider = "Amaudruz", Name = "Pêches", Quantity = 12, Unit = "kg", Price = 5.50m },
            new Product() { Location = "13", Provider = "Amaudruz", Name = "Haricots", Quantity = 13, Unit = "kg", Price = 5.20m },
            new Product() { Location = "13", Provider = "Amaudruz", Name = "Courges", Quantity = 7, Unit = "pièce", Price = 9.60m },
            new Product() { Location = "14", Provider = "Bühlmann", Name = "Tomates", Quantity = 12, Unit = "kg", Price = 7.70m },
            new Product() { Location = "14", Provider = "Bühlmann", Name = "Pommes", Quantity = 17, Unit = "kg", Price = 1.90m },
            new Product() { Location = "14", Provider = "Bühlmann", Name = "Poires", Quantity = 7, Unit = "kg", Price = 3.00m },
            new Product() { Location = "14", Provider = "Bühlmann", Name = "Pastèques", Quantity = 11, Unit = "pièce", Price = 6.90m },
            new Product() { Location = "14", Provider = "Bühlmann", Name = "Melons", Quantity = 7, Unit = "kg", Price = 4.70m },
            new Product() { Location = "15", Provider = "Crizzi", Name = "Noix", Quantity = 10, Unit = "sac", Price = 1.60m },
            new Product() { Location = "15", Provider = "Crizzi", Name = "Raisin", Quantity = 17, Unit = "kg", Price = 7.80m },
            new Product() { Location = "15", Provider = "Crizzi", Name = "Pruneaux", Quantity = 18, Unit = "kg", Price = 9.00m },
            new Product() { Location = "15", Provider = "Crizzi", Name = "Myrtilles", Quantity = 12, Unit = "kg", Price = 3.00m },
            new Product() { Location = "15", Provider = "Crizzi", Name = "Groseilles", Quantity = 12, Unit = "kg", Price = 3.50m }
            };

//1.
int howManyCurrants = products.Count(p => p.Name == "Groseilles");
//int howManyCurrants = products
//    .GroupBy(p => p.Name)
//    .Where(g => g.Key == "Groseilles")
//    .Select(g => g.Count())
//    .FirstOrDefault();

Console.WriteLine($"La quantité de groseilles disponibles sur le marché est " + howManyCurrants);

Console.WriteLine("------------------------------------------------------------------------------------------------------------");

//2.
var merchantRevenues = products
    .GroupBy(p => p.Provider)
    .Select(g => new
    {
        Merchant = g.Key,
        TotalRevenue = g.Sum(p => p.Price * p.Quantity)
    })
    .ToList();

merchantRevenues.ForEach(Console.WriteLine);

//var merchantRevenuesDict = products
//    .GroupBy(p => p.Provider)
//    .ToDictionary(
//        g => g.Key,                       // Merchant name
//        g => g.Sum(p => p.Price * p.Quantity) // Total revenue
//    );

//foreach (var kvp in merchantRevenuesDict)
//{
//    Console.WriteLine($"Merchant: {kvp.Key}, Total Revenue: {kvp.Value}");
//}

Console.WriteLine("------------------------------------------------------------------------------------------------------------");

//3.
var merchantRevenue = products
    .GroupBy(p => p.Provider)
    .Select(g => new
    {
        Merchant = g.Key,
        TotalRevenue = g.Min(p => p.Price * p.Quantity)
    })
    .ToList();

merchantRevenue.ForEach(Console.WriteLine);











class Product
{
    public string Location { get; set; }
    public string Provider { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Unit { get; set; }
    public decimal Price { get; set; }
}

