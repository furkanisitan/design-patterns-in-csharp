using System;

namespace CarProductionExample
{
    class Customer
    {
        public static void CarRequest(Brands brand, string model, params string[] requestParts)
        {
            Agency agency = new Agency();

            switch (brand)
            {
                case Brands.AUDI:
                    Audi audi = agency.AudiRequest(model, requestParts);
                    Console.WriteLine(audi.ToString());
                    break;
                case Brands.BMW:
                    Bmw bmw = agency.BmwRequest(model, requestParts);
                    Console.WriteLine(bmw.ToString());
                    break;
            }
        }
    }
}
