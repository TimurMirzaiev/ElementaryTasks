using System;
using System.Collections.Generic;
using System.Text;

namespace _5_NumberInWord.NumberInWordCore.ConsoleUI
{
    class NumberInWordUI
    {
        public void ShowMenu()
        {
            StringBuilder res = new StringBuilder();

            res.AppendLine(MenuText.MENU_TRANSFORM_COMMAND);
            res.AppendLine(MenuText.MENU_EXIT_COMMAND);

            Console.WriteLine(res.ToString());
        }

        public string[] ReadArgs()
        {
            return Console.ReadLine()?.Split(' ');
        }
    }
}
