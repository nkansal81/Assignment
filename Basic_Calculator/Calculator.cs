using System;
using System.Collections.Generic;

namespace Basic_Calculator
{
    class Calculotor
    {
        static void Main(string[] args)
        {
            Generic_Calculator.Arithematic_operation obj = new Generic_Calculator.Arithematic_operation();
            dynamic x = obj.Addition(4.4, 5.4);
            Console.WriteLine("The addition of two number is {0}", x);
            dynamic y = obj.subtraction(9.5, 8.3);
            Console.WriteLine("The subtraction of two number is {0}", y);

            dynamic z = obj.Multiplication(4, 2.2);
            Console.WriteLine("The multiplication two number is {0}", z);

            dynamic i = obj.Division(8.8, 2);
            Console.WriteLine("The division of two number is {0}", i);

            List<int> obj1 = new List<int>();
            Console.WriteLine("Enter the number of input");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine("Enter the input");
                int num = Convert.ToInt32(Console.ReadLine());
                obj1.Add(num);
            }
            int res = obj.Addition_for_n_input(obj1);
            Console.WriteLine("The sum of given inputs is {0}", res);

            Console.ReadKey();
        }
    }
}
