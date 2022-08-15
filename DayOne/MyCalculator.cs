using System;

namespace DayOne {
    public static class MyCalculator {
        public static double Add (double op1, double op2) {
            return op1 + op2;
        }
        public static double Sub (double op1, double op2) {
            return op1 - op2;
        }
        public static double Mul (double op1, double op2) {
            return op1 * op2;
        }
        public static double Div (double op1, double op2) {
            return op1 / op2;
        }
    }
    class MyCalculatorMain {
        static void Main (string[] args) {
            Console.WriteLine ("Add output :" + MyCalculator.Add (10, 20));
            Console.WriteLine ("Sub output :" + MyCalculator.Sub (10, 20));
            Console.WriteLine ("Mul output :" + MyCalculator.Mul (10, 20));
            Console.WriteLine ("Div output :" + MyCalculator.Div (10, 20));
        }
    }
}