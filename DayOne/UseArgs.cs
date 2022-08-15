using System;

namespace DayOne {
    class UseArgs {
        static void Main (string[] args) {
            foreach (string arg in args) {
                Console.WriteLine (arg);
            }
        }
    }
}