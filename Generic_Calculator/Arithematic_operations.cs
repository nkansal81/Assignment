using System;
using System.Collections.Generic;

namespace Generic_Calculator
{
    public class Arithematic_operation
    {
        public T Addition<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 + num2;
        }
        public T subtraction<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 - num2;
        }
        public T Multiplication<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 * num2;
        }

        public T Division<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic num3 = 0;
            if (num2 == 0)
            {
                Console.WriteLine("Division Not Posiible");
                return num3;
            }
            else
            {
                return num1 / num2;
            }
        }
        public int Addition_for_n_input(List<int> ls)
        {
            int sum = 0;
            foreach (int item in ls)
            {
                sum = sum + item;
            }

            return sum;
        }
    }

}