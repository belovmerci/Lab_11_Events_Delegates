using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab_11_Events_Delegates
{
    class RobotLogger
    {
        string message_holder;
        public RobotLogger()
        {
            message_holder = string.Empty;
        }

        public void WriteTest(string message)

        {
            if (message == "Return")
            {
                StreamWriter sw = new StreamWriter("test.txt");
                sw.Write(message_holder);
                sw.Close();
                message_holder = string.Empty;
            }
            else message_holder += (message + ' ');
        }
    }
}
