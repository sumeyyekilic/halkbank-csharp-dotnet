



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMechanisms
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class ProductCreatedEventArgs : EventArgs
    {
        public Product Product { get; set; }
        public string User { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class ProductService
    {
        //public delegate void CreatedEventHnadler(object sender, ProductCreatedEventArgs e);
        public event EventHandler<ProductCreatedEventArgs> Created;
        public void Create(Product product)
        {
            //db ye eklendikten sonra,()olay fırlatmak istiyoruz. 
            var eventArs = new ProductCreatedEventArgs
            {
                Product = product,
                CreatedDate = new DateTime(),
                User = "sumeyye"
            };
            onCreated(eventArs);
        }
        private void onCreated(ProductCreatedEventArgs eventArgs)
        {
            if(Created != null)
            {
                Created(this, eventArgs);
            }
        }
    }
    //
}
