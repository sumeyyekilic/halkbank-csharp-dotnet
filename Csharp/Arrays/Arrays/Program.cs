//22.01.2024 ***SumeyyeKilic

//1.tüm elemanları bildiğim durum
string[] days = new string[] { "Monday", "Tuesday", "Wednesday" };
//2.sadece kapasitesini bildiim durum
string[] students = new string[9];

//immmutable 

students[0] = "Sümeyye";
students[1] = "Bertan";

Console.WriteLine(students[1]);

//Array benim ne işime yarar, neden kullanırım
/*algoritma:  
 * 
 * kullanıcının girdiği iki haneli sayının okunuşunu yazın
 * 42 -> Kırk iki
 * 
 *
 * 594.556.561.493
 * 
 * 
 */


string[] onlar = {"", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan"};
string[] birler= {"", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz"};

//Console.WriteLine("0 ile 100 arasında bir sayi giriniz");

//var sayilar = int.Parse(Console.ReadLine());
//var onlarDegeri = sayilar / 10;
//var birlerDegeri = sayilar % 10;

//Console.WriteLine($"{onlar[onlarDegeri]} {birler[birlerDegeri]}");
//Console.WriteLine($"tekrar sayi çevirecek misiniz ? (E/H)");

//YUKARDAKİ YAPI EN AZ BİR KERE TEKRAR ETSİN İSTİYORUM. 
do
{
    Console.WriteLine("0 ile 100 arasında bir sayi giriniz");

    var sayilar = int.Parse(Console.ReadLine());
    var onlarDegeri = sayilar / 10;
    var birlerDegeri = sayilar % 10;

    Console.WriteLine($"{onlar[onlarDegeri]} {birler[birlerDegeri]}");
    Console.WriteLine($"tekrar sayi çevirecek misiniz ? (E/H)");

} while (Console.ReadLine() == "E");


//döngü array ve func
string numberToString(int number)
{
    string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
    string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

    var onlarDegeri = number / 10;
    var birlerDegeri = number % 10;

    return $"{onlar[onlarDegeri]} {birler[birlerDegeri]}";
}

for (int i = 0; i < 100; i++)
{
    string result =numberToString(i);
    Console.WriteLine(result);
}

//arrayi herzaman terch etmiyoruz. çok küçük yerlerde iht karşılıyor.
//3.eleman eklemek  --> //immutable 
//yeni arrayi 4elemanlı oluşturup, diğer arrayı bunun üzerine ekledikten sonra 4.errayi ekleybilirsin. bellekte bi fazla ve sonunccusu fazla olacak şekilde.... bu yöntem yerine list kullanılır.
List<string> list = new List<string>(); //list collection
//---------------

