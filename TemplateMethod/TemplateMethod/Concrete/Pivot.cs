using System;
using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete
{
    class Pivot : ReportHelper
    {
        public override void Render()
        {
            Console.WriteLine("Raporun matris sunumu");
        }
    }
}
