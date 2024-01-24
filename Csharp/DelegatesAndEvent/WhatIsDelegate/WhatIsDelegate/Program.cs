// See https://aka.ms/new-console-template for more information
using WhatIsDelegate;
//*delege ile lambda arasındaki ilişkiler*

int[] number = (int[])Enumerable.Range(0, 11).ToArray();
//.net 1.1
var evenNumber = FilterHelper.filter(number, isEven);
//.net2.0
var oldNumbers=FilterHelper.filter(number, delegate(int number) { return number % 2 == 1; });
    //burada isEven fiziksel olarak olmak zorunda değil(.net2)

//.Net 3,5
var lessThanFive=FilterHelper.filter(number, n => n < 5 ); //lambda func yukardaki delege. parametreyi

//.Net4.0 sonra microsoft delege yazma dedi. daha persormanslı yöntem : BuiltInJeneric delege
//geriye bişey döndürüyorsa Func olabilir
//lambda delefe çağırmak.
//değer döndürüyorsa func dır

Console.WriteLine("tek sayılar");
Show(oldNumbers);
Console.WriteLine("çift sayılar");
Show(evenNumber);
Console.WriteLine("5 den küçük sayılar");
alternateShow(lessThanFive);

//eger delege void olsaydı action olarak tanımlayacaktık..


//filtryi elemeayrı bi classa taşıdım
//int[] filter(int[] numbweParameter)
//{
//    List<int> result = new List<int>();
//    foreach (int i in numbweParameter)
//    {
//        //if (i % 2 == 0) //burdaki işi func yaptırıyorum
//        //{
//        //    result.Add(i);

//        //}

//        if (isEven(i)) 
//        { 
//            result.Add(i); 
//        }

//    }
//    return result.ToArray();
//}

bool isEven(int number)
{
    return number % 2 == 0;
}

void Show(int[] numbers)
{
    foreach (int i in numbers) { 
        
    }
}

void alternateShow(int[] numbers)
{
    //numbers.ToList().ForEach(n =>Console.WriteLine(n));
    numbers.ToList().ForEach(n =>showNumber(n));
}

void showNumber(int number)
{
    Console.WriteLine(number);
}