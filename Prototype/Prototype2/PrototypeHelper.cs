using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype2
{
    /*
    Bu örnekte nesne ilk olarak Serialization işlemine tabi tutulmuştur.
    
    Peki Serialization nedir?
    - Bir nesnedeki verilerin uygun formata dönüştürülmesi işlemine serialization denir.
    3 tip Serialization işlemi vardır.
    - Binary Serialization, SOAP Serialization, JSON Serialization
    Bu örnekte Binary Serialization kullanılmıştır.
        
    Daha sonra serileştirilmiş biçimdeki verilere Deserialization işlemi uygulanarak ilgili nesnenin
     derin koyası(deep copy) elde edilmiştir.

    [Serializable] => Bir sınıfın serileştirilebilir olduğunu gösterir.
    */

    [Serializable]
    public abstract class PrototypeHelper<T>
    {
        // Yüzeysel klonlama
        public T Clone()
        {
            return (T)MemberwiseClone();
        }

        // Derin kopyalama
        public T DeepCopy()
        {
            using (var ms = new MemoryStream())
            {
                // Serialization
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, this);

                // Deserialization
                ms.Seek(0, SeekOrigin.Begin);   // Serialization işlemi sonrası erişim pozisyonu ms nin sonunu işaret
                return (T)bf.Deserialize(ms);   //  eder. Bunun en başa alınması gerekir.
            }
        }
    }
}
