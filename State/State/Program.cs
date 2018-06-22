using State.Context;
using System;

namespace State
{
    /*
    Bu patern bir nesnenin durum bilgisinin değişmesiyle, değişen duruma göre davranışının da değişmesini tematize eder.
    Nesne bir durum makinesi olarak ele alınmalı ve olası her bir durum için ayrı bir sınıf oluşturulmalıdır.

    Paternin uygulanmasında 3 temel kısım bulunur.
    - State => Durum sınıflarının base' i. Interface veya abstract class olmalıdır.
    - ConcreteState => Durum sınıfları. Her sınıf, davranışını(metodları) kendi durumuna göre implemente eder.
    - Context => Durumu değişen nesnenin sınıfıdır.
    */

    class Program
    {
        static void Main(string[] args)
        {
            ThreadContext thread = new ThreadContext();
            thread.Start();
            thread.Start();
            thread.Sleep();
            thread.Start();
            thread.Abort();
            thread.Start();
            thread.Abort();
            thread.Abort();

            Console.ReadKey();
        }
    }
}
