using System;


namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            float perimeter = 2 * width + 2 * height;
            float area = width * height;
            Console.WriteLine(String.Format("{0:0.00} {1:0.00}", area, perimeter));
        }
    }
}
