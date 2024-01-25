using ExtensionMethod;

int x = 5;
//x. isimli deiğişkene özel metot eklemek istiyoruz. çalışacağım değer zaten int ise bu değişkeni başkabi claasın metoduna göndermek için

x.GetSquare();
Console.WriteLine(x.GetSquare());
string tableName = "Order Details";
Console.WriteLine(tableName.RemoveEmptySpaces());

string isim = "sümeyye kılıç";
Console.WriteLine(isim.ToTitleCase());


string isim2 = "mehmet ali birand";
Console.WriteLine(isim.ToTitleCase());

Console.WriteLine(new Random().NextString(8, true));