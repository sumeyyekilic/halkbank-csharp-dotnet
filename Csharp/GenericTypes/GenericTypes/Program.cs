using System.Collections;
using static GenericTypes.Point;

void IslemYap(object obj)
{
    Console.WriteLine(obj);
}

IslemYap("test");
IslemYap(9);
IslemYap(false);
IslemYap(new Random());

object obj = "deneme"; //->boxing

//boxing : bir veriyi ()değer) doğrudan objec tipine atamak
//unboxing : object tipine atanmış bir değeri, orjinal tipe dönüştürmek

string realType=(string)obj; //unboxing
//int realInt=(int)obj;      //kutuda stringi inte çeviremez
                             //unboxing in problemi bu.

ArrayList arrayList=new ArrayList();
arrayList.Add(realType);

PointGeneric<float> point = new PointGeneric<float>();
//point.Y ve point.X artık float 'dır.
//generic tipi sınırlayabilirriz.

PointGeneric2<Random> point2 = new PointGeneric2<Random>();
//point.X ve y random

//bazı oprasyonları pointera atfederek yapıyor olmak
//struct 


bool isEqual<T>(T value1, T value2)  where T : struct, IComparable<T>
{
    return value1.CompareTo(value2) == 0;
}

Console.WriteLine(isEqual(15, 10));
if (isEqual(10.0, 10.0))
{
    Console.WriteLine("eşit");
}
else
{
    Console.WriteLine("eşit değil");
}