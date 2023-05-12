using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_Events_Delegates
{
    class Delegates
    {
        public static double Square(double value) => value * value;
        public static double Half(double value) => value * 0.5;
        public static double Plusone(double value) => ++value;
        public static double Minusone(double value) => --value;

        delegate double Testdel(double value);

        public static void RunDelegates()
        {
            double double_value = 10.1;
            Testdel square = Square;
            Testdel half = Half;
            Testdel plusone = Plusone;
            Testdel minusone = Minusone;
            Testdel[] testdels = { square, half, plusone, minusone };

            for (int times = 0; times != 5; times++)
            {
                Testdel[] dels = new Testdel[10];
                for (int reps = 0; reps != 10; reps++)
                {
                    dels[reps] = testdels[(times + reps) % 3];
                }

                for (int reps = 0; reps != 10; reps++)
                {
                    double_value = dels[reps](double_value);
                    Console.WriteLine($"value at point {reps} is {double_value}");
                }
                Console.WriteLine();
                Console.WriteLine($"result is ${double_value}");
                Console.WriteLine();
                double_value = 10.1;
                // For easier readability
                Console.ReadKey();
            }
        }
    }
}
