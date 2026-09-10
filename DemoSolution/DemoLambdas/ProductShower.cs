namespace DemoLambdas;

public class ProductShower
{
	private static List<Product> s_products =
	[
		new() { Id = 1, Name = "Laptop", Price = 1299.99m },
		new() { Id = 2, Name = "Wireless Mouse", Price = 34.95m },
		new() { Id = 3, Name = "Mechanical Keyboard", Price = 89.50m },
		new() { Id = 4, Name = "27-inch Monitor", Price = 329.00m },
		new() { Id = 5, Name = "USB-C Dock", Price = 149.99m },
		new() { Id = 6, Name = "Webcam", Price = 74.95m },
		new() { Id = 7, Name = "Noise-Cancelling Headphones", Price = 249.00m },
		new() { Id = 8, Name = "Laptop Stand", Price = 44.50m },
		new() { Id = 9, Name = "USB-C Cable", Price = 19.95m },
		new() { Id = 10, Name = "External SSD 1TB", Price = 109.99m }
	];

	public static void ShowProducten(Func<Product, bool> condition, Action<Product> wegschrijver)
	{
		foreach (var product in s_products)
		{
			if (condition(product))
			{
				wegschrijver(product);
				// Console.WriteLine($"Product: {product.Name} cost {product.Price:C}");
			}
		}
	}
	
	public static void ShowDureProducten()
	{
		foreach (var product in s_products)
		{
			if (product.Price > 50m)
			{
				Console.WriteLine($"Product: {product.Name} cost {product.Price:C}");
			}
		}
	}

	public static void ShowProductenBeginnendMetLetter(string letter)
	{
		foreach (var product in s_products)
		{
			if (product.Name.StartsWith(letter))
			{
				Console.WriteLine($"Product: {product.Name} cost {product.Price:C} en begint met een {letter}");
			}
		}
	}
}