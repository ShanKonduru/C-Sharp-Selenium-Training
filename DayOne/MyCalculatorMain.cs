using System;

namespace DayOne {
    class MyCalculatorMain {
        static void Main (string[] args) {
            Console.WriteLine ("Add output :" + MyCalculator.Add (10, 20));
            Console.WriteLine ("Sub output :" + MyCalculator.Sub (10, 20));
            Console.WriteLine ("Mul output :" + MyCalculator.Mul (10, 20));
            Console.WriteLine ("Div output :" + MyCalculator.Div (10, 20));
        }
    }
}