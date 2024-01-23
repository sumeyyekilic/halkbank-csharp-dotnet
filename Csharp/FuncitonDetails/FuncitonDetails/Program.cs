using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncitonDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bolumdenKalan = 0;
            var bolumSonucu = divide(13, 3, out bolumdenKalan);
            Console.WriteLine(bolumdenKalan);//out kullanım amacı


            Console.WriteLine("bir sayi giriniz :");//out kullanım amacı
            var userValue = Console.ReadLine();
            int myIntegerValue = 0;
            while (!int.TryParse(userValue, out myIntegerValue))
            {
                Console.WriteLine("girdiğiniz değer sayıya çevrilemedi.");
                Console.WriteLine("lütfen bir sayı giriniz");
            }
            //eğer başarılı olduysa true dönüyor. exp yediyse false dönüyor, integerValue ya bir değer atamıyor

            int myReferance = 8;
            whatIsReference(myReferance);
            Console.WriteLine($"Main içinde: {myReferance}");
            //her metot skope u ram de belleğin ayrı bir yerinde saklanır.int value,myReference in karşılıığnı alsın. bellekteki aynı referasnı kullansınlar
             

            var ortalama = getAverage(16,5,-4,13,2,125,33);
            Console.WriteLine(ortalama);

        }

        static int divide(int a, int b, out int modulo)
        {
            modulo = a % b;
            return a / b;
        }


        static void whatIsReference(int value)
        {
            value += 5;
            Console.WriteLine($"whatIsReference içinde: { value} ");
        }



        static int getAverage(params int[] values)
        {
            return (int)values.ToList().Average();
        }


        //paradigma bir olayı ele alış biçimi yöntem
        //düşünme bçimi

        //bir problemi çöçözmek için kullandığımız bi yöntem
        //yazılım dünyasında neden nesnene yönelimil programlama tercih ediliyor
        //bazı startejiler i düşünelim
        /*

        platoncu yaklaşım tüm cocuklar kedşnşn kedi nesnesi olduğunu nerden biliyor
        etrafımızda gördüğümüz her nesnenin bir ideası var. tanımı var
        idea nesnelerin kusursuz tanımı

        OOP FELSEFİK Bİ KAVRAM



         classs idea
         obje nesne- inctance 
        
         
         */
    }
}
