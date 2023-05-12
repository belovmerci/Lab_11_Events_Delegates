using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_Events_Delegates
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lab 11.1 + Lab 11.2 by Belov 2207sv2 original copyright pls don't steal");
            Console.WriteLine("Вы хотите увидеть робота или делегатов в действии? (robot/любое значение)");
            string uservalue = Console.ReadLine();

            if (uservalue == "robot")
            {
                RobotLogger robotLogger = new RobotLogger();
                Robot robot = new Robot();
                robot.MsgEvent += robotLogger.WriteTest;
                for (int i = 0; i < 100; i++)
                {
                    robot.MakeMove();
                }
            }
            else Delegates.RunDelegates();
        }
    }
}
