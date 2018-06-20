using System;

namespace ExtensionMethods
{
    /*
    * ExtensionMethod özelliği sayesinde kaynak kodu elde olmayan(sealed sınıflara dahi)
    türetme yapılmaksızın yeni metodlar eklenebilir.
    * Extension metodlar statik bir sınıf içerisinde ve yine statik olarak yazılmalı,
    üstelik ilk parametresi (başında this anahtar sözcüğü olacak şekilde) hedef sınıfa ilişkin bir
    parametre olmalıdır.
    * Bu parametre metodun çağrılması sırasında görünmez.
    */

    static class StringVisitor
    {
        public static void Display(this string str, int count)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(str);
        }
    }
}
