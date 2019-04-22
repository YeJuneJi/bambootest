using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BambooTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calculate
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            if (a < b)
            {
                int temp = 0;
                temp = a;
                a = b;
                b = a;
            }
            return a / b;
        }
    }
}
