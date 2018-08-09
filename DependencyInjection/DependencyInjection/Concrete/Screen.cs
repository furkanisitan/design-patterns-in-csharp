using DependencyInjection.Abstract;
using System;

namespace DependencyInjection.Concrete
{
    public class Screen : IDisplayer
    {
        public void Display(string str)
        {
            Console.WriteLine(str);
        }
    }
}
