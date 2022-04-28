using SubWay.MakeSub;
using System;

namespace SubWay
{
    class Program
    {
        static void Main(string[] args)
        {
            ISub sub1 = new Sub();
            Console.WriteLine($"Description: {sub1.GetDescription()}");
            Console.WriteLine($"Description: {sub1.GetPrice()}");
            Console.WriteLine("");
            ISub sub2 = new SubAddCheese(sub1);
            Console.WriteLine($"Description: {sub2.GetDescription()}");
            Console.WriteLine($"Price: {sub2.GetPrice()}");
            Console.WriteLine("");
            ISub sub3 = new SubHeated(sub2);
            Console.WriteLine($"Description: {sub3.GetDescription()}");
            Console.WriteLine($"Price: {sub3.GetPrice()}");
            Console.WriteLine("");
            ISub sub4 = new SubShort(sub3);
            Console.WriteLine($"Description: {sub4.GetDescription()}");
            Console.WriteLine($"Price: {sub4.GetPrice()}"); 
            Console.WriteLine("");

            ISub sub5 = new SubShort(sub2);
            Console.WriteLine($"Description: {sub5.GetDescription()}");
            Console.WriteLine($"Price: {sub5.GetPrice()}");
            Console.WriteLine("");

            ISub sub6 = new SubHeated(sub1);
            Console.WriteLine($"Description: {sub6.GetDescription()}");
            Console.WriteLine($"Price: {sub6.GetPrice()}");
            Console.WriteLine("");

        }
    }
}
