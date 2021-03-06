﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _7_8_Sequences.SequencesCore.ConsoleUI
{
    class SequencesUI
    {

        public void ShowMenu()
        {
            StringBuilder res = new StringBuilder();

            res.AppendLine(MenuText.MENU_RANGE_FIBONACCI_COMMAND);
            res.AppendLine(MenuText.MENU_SQUARE_LESS_THAN_N_COMMAND);
            res.AppendLine(MenuText.MENU_EXIT_COMMAND);

            Console.WriteLine(res.ToString());
        }

        public string[] ReadArgs()
        {
            return Console.ReadLine()?.Split(' ');
        }

        public void ShowSequence(IEnumerable<int> sequence)
        {
            StringBuilder builder = new StringBuilder();

            foreach(int num in sequence)
            {
                builder.Append(String.Format("{0}, ", num));
            }

            Console.WriteLine(builder.ToString());
        }
    }
}