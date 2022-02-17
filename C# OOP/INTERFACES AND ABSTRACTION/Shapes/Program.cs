using System;

namespace Shapes
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable cirle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rectangle = new Rectangle(width, height);

            cirle.Draw();
            rectangle.Draw();
        }
    }
}
