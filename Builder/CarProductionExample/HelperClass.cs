using System.Collections.Generic;
using System.Text;

namespace CarProductionExample
{
    class HelperClass
    {
        public static string ToStringByBrand(string brand, string model,
            List<string> compulsoryParts, List<string> optionallyParts)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{brand} {model}");
            stringBuilder.Append("Zorunlu Parçalar => ");
            foreach (var item in compulsoryParts)
                stringBuilder.Append($"{item}, ");
            stringBuilder.Append("\nOpsiyonel Parçalar => ");
            foreach (var item in optionallyParts)
                stringBuilder.Append($"{item}, ");
            stringBuilder.AppendLine("\n");
            return stringBuilder.ToString();
        }

    }
}
