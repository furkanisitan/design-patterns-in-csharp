using DependencyInjection.Abstract;
using System;

namespace DependencyInjection.Concrete
{
    public class Page:IDisplayer
    {
        public void Display(string str)
        {
            // Response.Write($"<span>{str}</span>");
            Console.WriteLine($"<span>{str}</span>");
        }
    }
}
