using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Pages
{
    abstract class SomePage
    {
        public bool Confirm(string usercommand)
        {
            if (usercommand == "y")
            {
                return true;
            }
            else if (usercommand == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Type y or n");
                usercommand = Console.ReadLine();
                return Confirm(usercommand);
            }

        }
        public void MakePageTitle()
        {
            int len = Console.WindowWidth - 1;
            var builder = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                builder.Append("#");
            }
            var str = builder.ToString();

            string ver = "Notes ver 1.0";

            Console.Clear();
            Console.WriteLine(str + "\n" + ver + "\n" + str);
        }
    }
}
