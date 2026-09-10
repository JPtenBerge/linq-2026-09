using DemoLambdas;

Console.OutputEncoding = System.Text.Encoding.UTF8;

ProductShower.ShowDureProducten();
Console.WriteLine("==================== 💯💯🎊⬆️👻");
ProductShower.ShowProductenBeginnendMetLetter("U");
Console.WriteLine("==================== 💯💯🎊⬆️👻");


// Predicate<Product> dureProductenPredicate = delegate(Product product) // anonieme method / inline method / mini-interface
// {
// 	return product.Price > 50m;
// };
Func<Product, bool> dureProductenPredicate2 = delegate(Product product) // anonieme method / inline method / mini-interface
{
	return product.Price > 50m;
};

ProductShower.ShowProducten(dureProductenPredicate2, p => Console.WriteLine($"Product: {p.Name} cost {p.Price:C}"));

ProductShower.ShowProducten(p => p.Name.StartsWith("U"), p => Console.WriteLine($"Product: {p.Name} cost {p.Price:C} en begint met U"));
