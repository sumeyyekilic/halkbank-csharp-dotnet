using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsDelegate
{
    internal class FilterHelper
    {
        public delegate bool Criteria(int number);
        public static int[] filter(int[] numbweParameter, /*func için*/ Criteria filterCriteria)
        {
            //istenilen func için


            List<int> result = new List<int>();
            foreach (int i in numbweParameter)
            {

                //if (isEven(i)) //başka bi classtan bu fonksşyon çağrılamıyor. 
                // isEven() çalışması içim ,bir fonksiyonu başka sınıfın fonksiyonuna parametre olarak göndermek gerek

                //fucnc, func 'a parametre olarak gönderilemez
                //delegate*******
                //{
                //    result.Add(i);
                //}

            }
            return result.ToArray();
        }

        ///************************.net 4 sonrası
        public static int[] filter2(int[] numbweParameter, Func<int, bool> filterCriteria)
        {
            List<int> result = new List<int>();
            foreach (int i in numbweParameter)
            {

                if (filterCriteria(i))
                {
                    result.Add(i);
                }    
            }
            return result.ToArray();
        }
    }
}
