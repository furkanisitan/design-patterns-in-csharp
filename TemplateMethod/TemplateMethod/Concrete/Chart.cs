using System;
using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete
{
    class Chart : ReportHelper
    {
        public override void Render()
        {
            Console.WriteLine("Raporun grafik sunumu");
        }
    }
}
