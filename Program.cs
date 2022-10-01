using Microsoft.SqlServer.Server;
using seminar_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace seminar_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            OPZ oPZ = new OPZ();
            MyStack<char> myStack = new MyStack<char>();
            oPZ.SoursString = Console.ReadLine();
            foreach (char c in oPZ.SoursString)
            {
                if (Convert.ToInt32(c)*1 == c)
                {
                    oPZ.OPZString += c;
                }
                else
                {
                    myStack.Push(c);
                }
            }
            foreach (char c in myStack.ToString())
            {
                if (oPZ.Priority(c) == 0)
                {
                    myStack.Push(c);
                }
                else if (oPZ.Priority(c) == 1)
                {
                    foreach (char item in myStack.ToString())
                    {
                        oPZ.OPZString += item;
                        myStack.Pop();
                    }
                }
            }
        }
    }
}
