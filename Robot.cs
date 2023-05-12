using System;
using System.Collections.Generic;
// using System.Random;
using System.Text;


namespace Lab_11_Events_Delegates
{
    class Robot
    {
        public delegate void MsgDelegate(string message);
        public event MsgDelegate MsgEvent;

        static readonly string[] RobotActions = { "Forward", "Back", "Left", "Right", "Return" };

        public void MakeMove()
        {
            var rand = new Random();
            this.MsgEvent(RobotActions[rand.Next(0, 4)]);
        }
    }
}
