using System;

namespace Store_Boxes_Objects_and_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Box
    {
        public Box()
        {
            ItemName = new ItemName();
        }
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemQuality { get; set; }
        public double Price { get; set; }
    }
}
