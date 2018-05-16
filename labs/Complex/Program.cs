using System;

namespace ComplexNumbers
{
    class Program
    {
        static void doWork()
        {
            Complex first = new Complex(10,4);
            Complex second = new Complex(5, 2);

            Console.WriteLine($"first is {first}");
            Console.WriteLine($"Second is {second}");

            Complex temp = first + second;
            Console.WriteLine($"Added: result is {temp}");

            temp = first - second;
            Console.WriteLine($"Subtract: result is {temp}");

            temp = first * second;
            Console.WriteLine($"Multiply: result is {temp}");

            temp = first / second;
            Console.WriteLine($"Division: result is {temp}");

            if (temp == first)
            {
                Console.WriteLine("temp = first");
            }
            else
            {
                Console.WriteLine("comparison temp != first");
            }
            if (temp == second)
            {
                Console.WriteLine("comparison temp == second");
            }
            else
            {
                Console.WriteLine("comparison temp != second");
            }

            temp += 2;
            Console.WriteLine($"value after adding 2: temp = {temp}");

            int tempInt = (int)temp;
            Console.WriteLine($"int value after conversion: tempInt == {tempInt}");

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
