using System.Collections.Generic;

namespace Builder
{
    class Product
    {
        private List<string> Parts = new List<string>();

        public void Add(string part)
        {
            Parts.Add(part);
        }

        public override string ToString()
        {
            string s = "Ürüne ait parçalar : \n\r";
            foreach (var p in Parts)
                s += $"{p}\n\r";
            return s;
        }

    }
}
