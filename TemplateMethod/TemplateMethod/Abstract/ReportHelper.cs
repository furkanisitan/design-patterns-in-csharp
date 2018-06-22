using System;

namespace TemplateMethod.Abstract
{
    abstract class ReportHelper
    {
        // Template metod
        public void CreateReport()
        {
            Query();
            Render();
        }
        private void Query()
        {
            Console.WriteLine("Kayıtlar veritabanından sorgulandı");
        }

        // Primitif metod
        public abstract void Render();
    }
}
