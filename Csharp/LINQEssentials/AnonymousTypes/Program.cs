using AnonymousTypes;

var aNumber = 8;
var aWord = "elektrik";
var random = new Random();
var product = new { Ad = "maouse", Fiyat = 2000 };//bellekte böyle bi obje söz konusu değil. peki neden bunu kullanmalıyım?
                                                  //language integrated query ile alakalı.
                                                  //sorgu mekanizmasının dile  dahil edilmiş hali. c# a tsql eklenmesi.
showDetails(product);

void showDetails(object product)
{
    //var info = (new {Name="", Price=0 })(product); //casting olması lazım
    Console.WriteLine(product);
    //dynamic keyword
    dynamic anonProduct = product;
    Console.WriteLine(product.Ad);

}
var products = new ProductService().GetProducts();
var spesificProducts = from p in products
                       select new
                       {
                           p.Name,
                           p.Price
                       };//burayı metot içine alıp obje döndürebilrim.
//select * from products
//sql from prod dan çalıştırmaya başlar. belleğe atar ve çalıştırır.

spesificProducts.ToList().ForEach(p => Console.WriteLine(p.Name));
//p anonim
//select Name as 'Ad', Price as 'Fiyat' from products
spesificProducts.ToList().ForEach(p => Console.WriteLine(p.Ad));















