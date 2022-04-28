using SubWay.MakeSub;
using System;

namespace SubWay
{
    class Program
    {
        static void Main(string[] args)
        {
            ISub sub1 = new Sub(); // Base Sub
            Console.WriteLine($"Description: {sub1.GetDescription()}");
            Console.WriteLine($"Description: {sub1.GetPrice()}");
            Console.WriteLine("");
            ISub sub2 = new SubAddCheese(sub1); // Base Sub + with cheese
            Console.WriteLine($"Description: {sub2.GetDescription()}");
            Console.WriteLine($"Price: {sub2.GetPrice()}");
            Console.WriteLine(""); 
            ISub sub3 = new SubHeated(sub2); // Base Sub + with cheese + heated
            Console.WriteLine($"Description: {sub3.GetDescription()}");
            Console.WriteLine($"Price: {sub3.GetPrice()}");
            Console.WriteLine("");
            ISub sub4 = new SubShort(sub3); // Base Sub + with cheese + heated + half size
            Console.WriteLine($"Description: {sub4.GetDescription()}");
            Console.WriteLine($"Price: {sub4.GetPrice()}"); 
            Console.WriteLine("");

            ISub sub5 = new SubShort(sub2); // Base Sub + with cheese + half size
            Console.WriteLine($"Description: {sub5.GetDescription()}");
            Console.WriteLine($"Price: {sub5.GetPrice()}");
            Console.WriteLine("");

            ISub sub6 = new SubHeated(sub1); // Base Sub + heated 
            Console.WriteLine($"Description: {sub6.GetDescription()}");
            Console.WriteLine($"Price: {sub6.GetPrice()}");
            Console.WriteLine("");

        }
    }
}
