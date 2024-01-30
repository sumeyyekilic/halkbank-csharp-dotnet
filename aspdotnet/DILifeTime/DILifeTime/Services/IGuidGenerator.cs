using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace DILifeTime.Services
{
    public interface IGuidGenerator
    {
        Guid Guid { get; } //sadece ctor da oluşturulacağı için get edilebilecek
    }

    //üç yöntem var:singleton, transient ve scoped
    public interface ISingletonGuid : IGuidGenerator { }
    public interface ITransientnGuid : IGuidGenerator { }
    public interface IScopednGuid : IGuidGenerator { }

    //BUNLARDAN TÜRETİLMİŞ 
    public class Singleton : ISingletonGuid
    {
        public Singleton()
        {

            //her zaman aynı guidi kullanıcak
            Guid = Guid.NewGuid();


        }

        public Guid Guid { get; }
    }

    public class Scoped : IScopednGuid
    {
        public Scoped()
        {
            Guid = Guid.NewGuid();

        }
        public Guid Guid { get; }

    }


    public class Transient : ITransientnGuid
    {
        public Transient()
        {
            Guid = Guid.NewGuid();

        }
        public Guid Guid { get; }

    }


    public class GuidService
    {
        public ISingletonGuid SingletonGuid { get; }
        public IScopednGuid ScopednGuid { get; }
        public ITransientnGuid TransientnGuid { get; }
        public GuidService(ISingletonGuid singletonGuid, IScopednGuid scopednGuid, ITransientnGuid transientnGuid)
        {
            SingletonGuid = singletonGuid;
            ScopednGuid = scopednGuid;
            TransientnGuid = transientnGuid;
        }

        
    }
}

