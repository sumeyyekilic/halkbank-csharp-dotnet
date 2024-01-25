using LINQSamples;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

List<Product> GetProductsByMoreThan(decimal price)
{
    var availableProducts = new List<Product>();
    var products = new ProductService().GetProducts();
    foreach (var product in products)
    {
        if (product.Price > price)
        {
            availableProducts.Add(product);
        }
    }

    return availableProducts;
}

List<Product> GetProductsByMoreThanLinq(decimal price)
{

    var products = new ProductService().GetProducts();
    return (
             from product in products
             where product.Price > price
             orderby product.Name
             select product

            ).ToList();



}
List<Product> GetProductsByMoreThanExtensions(decimal price)
{

    var products = new ProductService().GetProducts();
    return products.Where(product => product.Price > price)
                   .OrderBy(product => product.Name)
                   .ToList();



}


#region LINQ Ornekleri

var allProducts = new ProductService().GetProducts();
var cheapestProducts = allProducts.Where(p => p.Price <= 10500);

Console.WriteLine("10500 TL den ucuz ürünler");
Console.WriteLine("-------------------------");
cheapestProducts.ToList().ForEach(p => Console.WriteLine($"{p.Name}\t{p.Price}\t{p.Description}\t{p.CategoryName}"));

var product=allProducts.FirstOrDefault( p=>p.Description.Contains("Android")); 
//null olmasın istersek;
var product = allProducts.FirstOrDefault(p => p.Description.Contains("Android"), new Produc={ Description="bu kategorride urun yok");
//new ile default olarak belirtme .net6 ve sonrasında
Console.WriteLine("Açıklamasında android olan ilk ürün");
Console.WriteLine("------------------------------------");
Console.WriteLine($"{product?.Name}\t{product?.Price}\t{product?.Description}\t{product?.Category?.Name}");

Console.WriteLine();
Console.WriteLine("SingleOrDefault demo");
Console.WriteLine("-----------------------");
var singleProduct = allPoducts.SingleOrDefault(p => p.Id == 3, new Product { Description = "Bu kategoride ürün yok!" });
//single ve first arasındaki fark
//first or da kolleksiyon dönmesine izin veriyor, SingleOrDefoult izin vermiyor.


Console.WriteLine($"{singleProduct?.Name}\t{singleProduct?.Price}\t{singleProduct?.Description}\t{singleProduct?.Category?.Name}");
#endregion
