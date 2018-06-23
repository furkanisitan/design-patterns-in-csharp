using Interpreter.Abstract;
using Interpreter.Concrete;
using Interpreter.Context;
using System;
using System.Collections.Generic;

namespace Interpreter
{
    /*
    * Bu patern; belirli bir amaç için yaılmış, belirli bir sentaks veya notasyona sahip ifadelerin yorumlanmasını
    ve çalıştırılmasını tematize eder.

    Bu paternde 4 temel kısım vardır.
    - Context => Interpereter(yorumlayıcı) tarafından yorumlanacak olan bilgiyi saklayan nesnenin sınıfıdır.
    - AbstractExpression(Term) => Yorumlama sitemindeki yorumlayıcı sınıflar için ortak taban sınıf veya arayüzdür.
    - TerminalExpression => AbstractExpression sınıfını implemente eden, yorumlama mantığını içeren sınıf(lar)dır.
    - NonTerminalExpression => AbstractExpression sınıfını implemente eder. TerminalExpression'dan farkı;
    AbstractExpression sınıfından türeyen(terminal veya nonterminal) nesneleri kendi içinde barındırabilir.
    */

    class Program
    {
        /*
        - Bu örnek, elektronikte kullanılan dirençlerin değerlerini üzerindeki renklere göre belirlemekle ilglidir.
        - Direnç üzerinde 4 adet renk bandı vardır.
        - 1) İlk iki banddaki renklerin ifade ettikleri rakamlar yanyana getirilir. (Örn; 7,4 => 74)
        - 2) 3. banddaki renk, çarpan değerini belirtir. (10^4, 10^2 gibi)
        - 3) 4. banddaki renk, tolerans değerini belirtir. (%5 toleransı vs. gibi)
        - Bu iş mantığına göre sınıflar oluşturulmuştur.
        - Band1_2 sınıfı 1. işlemi, Band3 sınıfı 2. işlemi, Band4 sınıfı 3. işlemi yerine getirir.
        */

        static void Main(string[] args)
        {
            Resistance context = new Resistance("yellow-purple-red-gold");
            List<Expression> expressions = new List<Expression>()
            {
                new Band1_2(), new Band3(), new Band4()
            };
            foreach (var item in expressions)
                item.Interpret(context);
            Console.WriteLine(context.Output);

            Console.ReadKey();
        }
    }
}
