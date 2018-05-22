
namespace Builder
{
    class Director
    {
        public static void Construct(Builder builder, string[] parts)
        {
            foreach (var p in parts)
                builder.BuildPart(p);
        }
    }
}
