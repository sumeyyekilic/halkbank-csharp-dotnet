// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace   EnumDetails
{

    internal class Program {
        static void Main()
        {
            AkrabalikTipleri akrabalikTipleri = AkrabalikTipleri.Abi |
                                                AkrabalikTipleri.Ogul |
                                                AkrabalikTipleri.Baba |
                                                AkrabalikTipleri.Amca |
                                                AkrabalikTipleri.Dayi |
                                                AkrabalikTipleri.Dede ;
            Console.WriteLine((int)(akrabalikTipleri));
            
        }
    }
 

    public enum AkrabalikTipleri
    {
        Abi=1,
        Ogul=2, 
        Baba=4,
        Amca=8, 
        Dayi=16, 
        Dede=32
    }
}