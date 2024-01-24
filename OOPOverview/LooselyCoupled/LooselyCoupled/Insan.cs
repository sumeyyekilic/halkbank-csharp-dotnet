using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{
    public interface IKiyafet
    {

    }
    public class UstGiyim : IKiyafet {}

    public class Kazak :UstGiyim { }
    public class KirmiziKazak :Kazak
    {

    }
    public abstract class Insan
    {
        public void Giy(Kazak kazak)
        {
            //interface birbiri ile alakası olmayan - pantolon ve şapka - 
            //ucak ve güvercin uabiliyor diye uçağı güvercinden miras mi alabilir
            //uçabilecek herşeyi implemente edebilriz

        }
    }

}
