using Encapsulation;

Product product = new Product();
//product.Price = -5; 

product.SetPrice(15);
//product.IsStock = false; set edilemez
Console.WriteLine(product.GetPrice());


product.Description = "Test...";
Console.WriteLine($"Açıklama: {product.Description} ");
product.StockCount = 5;
product.DecreaseStock(5);
if (!product.IsStock)
{
    Console.WriteLine("stokta kalmadı");

}