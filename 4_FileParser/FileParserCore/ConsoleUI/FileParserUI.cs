﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _4_FileParser.FileParserCore.ConsoleUI
{
    class FileParserUI
    {
        public void ShowMenu()
        {
            StringBuilder res = new StringBuilder();

            res.Append(MenuText.MENU_COUNT_COMMAND);
            res.Append(String.Format(" {0}", MenuText.MENU_PATH_PARAM));
            res.AppendLine(String.Format(" {0}", MenuText.MENU_STRING_PARAM));

            res.Append(MenuText.MENU_REPLACE_COMMAND);
            res.Append(String.Format(" {0}", MenuText.MENU_PATH_PARAM));
            res.Append(String.Format(" {0}", MenuText.MENU_STRING_PARAM));
            res.AppendLine(String.Format(" {0}", MenuText.MENU_STRING_PARAM));

            Console.WriteLine(res);
        }

        public string[] ReadArgs()
        {
            return Console.ReadLine()?.Split(' ');
        }

        public void ShowCountOfStrings(int count)
        {
            Console.WriteLine("{0}: {1}", MenuText.MENU_RESULT_COUNT_OF_STRINGS, count);
        }

        public void ShowDescriptionCommandCounting()
        {
            StringBuilder res = new StringBuilder();

            res.Append(String.Format(" {0}", MenuText.MENU_PATH_PARAM));
            res.AppendLine(String.Format(" {0}", MenuText.MENU_STRING_PARAM));

            Console.WriteLine(res);
        }

        public void ShowDescriptionCommandReplace()
        {
            StringBuilder res = new StringBuilder();

            res.Append(String.Format(" {0}", MenuText.MENU_PATH_PARAM));
            res.Append(String.Format(" {0}", MenuText.MENU_STRING_PARAM));
            res.AppendLine(String.Format(" {0}", MenuText.MENU_STRING_PARAM));

            Console.WriteLine(res);
        }
    }
}