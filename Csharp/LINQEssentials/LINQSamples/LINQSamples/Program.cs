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

//açıklamasına göre ürünleri baştan sona sıralansın
Console.WriteLine("Açıklamasına ve sonra fiyata göre ürünler");
allProducts.OrderByDescending(p => p.Description).tThenByDescending(p => p.Price).ToList().ForEach(p => Console.WriteLine($"{p.Name}\t{p.Description}\t{p.Category.Name}"));
//sizin verdiğniz sıraya göre sıralar. 
allPoducts.Where(p => p.Category.Name.Contains("Telefon"))
          .Select(p => new { p.Name, p.Price, p.Description, CategoryName = p?.Category?.Name })
          .OrderByDescending(p => p.Description)
          .ThenByDescending(p => p.Price)

          .ToList()

          .ForEach(p => Console.WriteLine($"{p.Name}\t{p.Price}\t{p.Description}\t{p.CategoryName}"));



/* SELECT * FROM Products 
 * WHERE Products.Category.Name = "Telefon"
 * ORDER BY Description DESC
 * ORDER BY Price ASC
*/

var totalPrice = allPoducts.Sum(p => p.Price);
var averagePrice = allPoducts.Average(p => p.Price);
Console.WriteLine("Toplam Fiyat\tOrtalama Fiyat\tMaksimum\tMinimum");
Console.WriteLine($"{totalPrice}.....\t{Math.Ceiling(averagePrice)}.........\t{allPoducts.Max(p => p.Price)}.....\t{allPoducts.Min(p => p.Price)}");

Console.WriteLine("En pahalı ürün:");
Console.WriteLine("-------------------");
var expensiveProduct = allPoducts.FirstOrDefault(p => p.Price == allPoducts.Max(p => p.Price));
Console.WriteLine($"{expensiveProduct.Name}\t{expensiveProduct.Price}");
//.net6 dan sonra gelen
var expensiveAfterdotnet6 = allPoducts.MaxBy(p => p.Price);
Console.WriteLine($"{expensiveAfterdotnet6.Name}\t{expensiveAfterdotnet6.Price}");

Console.WriteLine("Maksimum");
Console.WriteLine($"{allPoducts.Max().Price}");

var categories = new ProductService().GetCategories();

var anotherAllProducts = new ProductService().GetProducts();
#region MyRegion
var phone = new Category() { Id = 1, Name = "Phone" };
var wearing = new Category() { Id = 21, Name = "Wearing" };
var Eelectronic = new Category() { Id = 3, Name = "Phone" };
Lis<Category> category = new { phone, wearing, Eelectronic };
List<Product> anathorProduct = new List<Product>()
{
    new(){Id=5, Name ="Telefon A", Description="Android", IsStock= true, Price=8500, Category = phone},
                new(){ Id=6, Name ="Telefon B", Description="Android", IsStock= true, Price=10500, Category = phone},
                new(){ Id=7, Name ="Telefon C", Description="IoS", IsStock= true, Price=78500, Category = phone},
                new(){ Id= 8, Name ="Telefon D", Description="Android", IsStock= true, Price=12500, Category = phone},
                new(){ Id= 9, Name ="Tekstil X", Description="Tişört", IsStock= true, Price=500, Category = phone},}
};
#endregion
var joinQuery = categories.Join(anotherAllProducts,
                                category => category,
                                product => product.Category,
                                (category, product) => new { KategoriAdi = category.Name, UrunAdi = product.Name }).ToList();

Console.WriteLine("JOIN sonucu:");
Console.WriteLine("......................");
foreach (var item in joinQuery)
{
    Console.WriteLine($"{item.KategoriAdi}: {item.UrunAdi}");
}

Console.WriteLine("Alternatif:");
Console.WriteLine("-------------------------");
anotherAllProducts.Select(p => new { ProductName = p.Name, CategoryName = p.Category.Name })
                  .ToList()

                .ForEach(p => Console.WriteLine($"{p.ProductName}, {p.CategoryName}"));

/* 
 *bir müşteri nesnesi ve müşteri koleksiyonumuz var
 *eğer hangi ülkede kaç müşteri old merak editorsanız
 *group by ile ülkeye göre iki gruba ayırırsınız. (bir tarafta ülkeler- bir tarafta müşter,ler. küme gibi)
 *
 *
 *  Ülke    Müşteri Sayısı
 *  -----------------------
 *  Türkiye     570
 *  Azerbaycan  400
 *  Kırgızistan 30
 *
 **
 */

//tüm ürünleri açıklamalarına göre gruplamak istiyorum
/*
 *SELECT Description , Count(Id)
 *From Products
 *
 */
var qroupByQuery = anathorProduct.GroupBy(keySelector: p => p.Description,
    elementSelector: element => new { element.Name, element.Price },
    resultSelector: (key, products) => new
    {
        Key = key,
        Count = products.Count(),
        MaxPrice = products.Max(),
        Total = product.Sum(product => product.Price),
        Average = products.Average(p => p.Price)
    });
Console.WriteLine("Açıklamaya göre gruplanmış çıktı");
Console.WriteLine("--------------------------------");
foreach (var gruping in qroupByQuery)
{
    Console.WriteLine($"{gruping.Key} \t{gruping.Count}\t{gruping.MaxPrice}\t{gruping.Total}\t{gruping.Average}")
}

var chunkProducts= anathorProduct.Chunk(3); //sıralı koleksiyon

//tekrar edenlerden yanlızca bir tanesini getir
var distincSample = anathorProduct.Distinct();
Console.WriteLine("Distinc result");
distincSample.ToList().ForEach(p => Console.WriteLine(p.Name));

