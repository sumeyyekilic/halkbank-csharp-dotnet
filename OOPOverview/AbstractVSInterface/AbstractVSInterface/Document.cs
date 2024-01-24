using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVSInterface
{
    public interface IPrintable
    {
        //sadece çıktısı alınabilecek dökümanlar
        void Print();
    }
    //bir clas birden fazla interface'i implemente edebilir.Birden fazla özellik kazandırabiliriz.. kod yazan kişi akşam eve gidince gitar çalabilir.. printer component

    public interface IAttachable
    {
        void Attach();
    }
    public abstract class Document
    {
        public string Title { get; set; }


        public string Creator { get; set; }
        public void Copy(string from, string to) 
        {
            Console.WriteLine("koplayandı");

        }
        public void Move(string from, string to)
        {
            Console.WriteLine("taşındı");

        }

        /* uygulama dökümanaımız her şey olabilir.  bu yüzden abstract
         *her dökümanın başlığı-sahibi-
         *çok sayfadan oluşan pdf mi excel mi?
         *sistem den harddiske kaydedip okuyabilirim 
         *dokumanın türüne göre save biçimi değişir. dökğmandan miras alan herhangi bi classın save biçimi farklı olmalı
         *
         *her dökğman kaydedilecek ama nasıl kaydedilecceğini miras alan belirleyecek
         *
         *eğer metodunuz abstr ise override etmeye mecbursun
         *abstract olmayan fonksiyonlarda var.
         *bir
         */
        public abstract void Save();
        public abstract void Load();
        //public abstract void Print();
        //PRİNT OLMA DURUMU yeteneğe dönüşür. dökümanların çıktı alınamayacağı gibi herinsan  resim yapamaz, kod yazamaz. nesnelerin yetenekleri demek olur. print zorunlu bir fonksiyon değil, bir yetenek, yapılabilirlik.
        
        

    }
    public class WordDocument : Document, IPrintable, IAttachable
    {
        public void Attach()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }
        public /*override*/ void Print()
        {
            throw new NotImplementedException();
        }
        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
    public class PdfDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }
        //public override void Print()
        //{
        //    throw new NotImplementedException();
        //}
        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
    public class ExcelDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Excel çıktısı alındı");

        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
    public class PrinterComponent
    {
        public void Print(IPrintable document)
        {
            document.Print();   

        }
    }


}
