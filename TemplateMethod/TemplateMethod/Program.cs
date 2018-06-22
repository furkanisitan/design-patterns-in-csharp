using System;
using TemplateMethod.Abstract;
using TemplateMethod.Concrete;

namespace TemplateMethod
{
    /*
    * Bu patern bir metodun(çağıran metod) kendi içinde çağırdığı metodların soyut olmaları yoluyla alt sınıflar tarafından
    farklı implementastyonlarının olmasını, böylece çağıran metodun yaptığı işin farklılaştırılmasını tematize eder.
    * Template Metod => Soyut bir taban sınıf içinde kodlanır. (Çağıran metod)
    * Primitif Metod => Template metodun çağırdığı soyut metodlar.
    * Primitif metodlar sayesinde Template metodun çalışma biçimi değiştirilir.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Report(new Chart());
            Report(new Pivot());

            Console.ReadKey();
        }

        static void Report(ReportHelper report)
        {
            report.CreateReport();
        }
    }
}
