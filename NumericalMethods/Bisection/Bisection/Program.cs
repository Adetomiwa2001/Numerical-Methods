﻿using System;

namespace Bisection
{
    class MainClass:NumericalMethods
    {
        public static void Main()
		{
			Double[] equation = { 25, 5, 1, 106.8 };
            Console.Write("Enter the value for a: ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value for b: ");
            Double b = Convert.ToDouble(Console.ReadLine());
            Bisection bisection = new Bisection(equation, a, b);
            bisection.Bisect();
        }
    }
}
