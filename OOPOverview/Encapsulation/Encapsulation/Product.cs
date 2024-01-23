using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {

        private decimal price { get; set; }
        public void SetPrice(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(value)} parametre değeri negatif olamaz");
            }
            this.price = value;

        }


        public decimal GetPrice()
        {
            return this.price;
        }
        //bir özeliiği oluşturan iki func var. get  ,set dışardan atanan fielda aktarmak için kullanılır
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description { get; set; } //--> decription u set etmediiğiniz sürece bellekte oluşmaz. normalde field olduğunda bellekte erişilemez ama bellekte oluşur gibi.kullanmıyorsan veya inctance ı yoksa bellekte yer kaplamıyor.
                                              /* ikiside yer kaplar.   
                                              *   Product.Description="";
                                              *   Cnsole.WriteLine($"Acıklama : {product.Description}")
                                              */
                                                          

        public int StockCount { get; set; }
        public bool IsStock { get; private set; } = true;
        public void DecreaseStock(int count)
        {

            StockCount -= count;
            if (StockCount <= 0)
            {
                IsStock = false;
            }
        }
        //mantıklı değil. Amaç write-only özellik göstermek:
        public string EmailAddress { private get; set; }
    }


}
