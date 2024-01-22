
Console.WriteLine("şu seçeneklerden birnin girin :  kırmızı, sarı, yeşil");
string trafikLambasi=Console.ReadLine();
if (trafikLambasi=="kirmizi")
{
    Console.WriteLine("dur");

}
else if (trafikLambasi == "sari") 
{
    Console.WriteLine("bekle");
}
else if (trafikLambasi == "yesil")
{
    Console.WriteLine("geç");
}
else 
{
    Console.WriteLine("hatali giris");
}

switch(trafikLambasi) //çamasır makinesinin üzerindeki yumarlak düğmesi gibi. 
{
    case "kirmizi":
        Console.WriteLine("dur");
        break;
    case "sari":
        Console.WriteLine("bekle");
        break;
    case "yesil":
        Console.WriteLine("geç");
        break;
    default:
        break;
}