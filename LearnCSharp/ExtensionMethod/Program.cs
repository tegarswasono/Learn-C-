using System;
using System.Collections.Generic;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 8000;
            Console.WriteLine(Utils.addRp(price));

            List<int> queue = new List<int>();
            queue.Add(4);
            queue.Add(7);
            queue.Add(14);
            var result = queue.makeToBeString();
            Console.WriteLine(result);

            string number = "5";
            long? resultLong = number.changeStringToBeLong();

            string text = "Saya sedang makan nasi di dapur";
            string result2= text.TakeLeft(10);

            Console.ReadLine();
        }
    }
}
