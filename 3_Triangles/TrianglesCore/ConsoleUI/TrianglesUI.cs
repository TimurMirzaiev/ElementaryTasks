using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Triangles.TrianglesCore.ConsoleUI
{
    class TrianglesUI
    {
        public void ShowMenu()
        {
            StringBuilder res = new StringBuilder();
            res.Append(MenuText.MENU_ADD_TRIANGLE_COMMAND);
            res.AppendLine(MenuText.MENU_ADD_TRIANGLE_DESCRIPTION);
            res.AppendLine(MenuText.MENU_ADD_TRIANGLE_WARNING);
            res.AppendLine(MenuText.MENU_ADD_TRIANGLE_SUBDESCRIPTION);
            res.AppendLine(MenuText.MENU_EXIT_COMMAND);

            Console.WriteLine(res.ToString());
        }

        public string[] ReadTriangle()
        {
            string line = Console.ReadLine();
            string[] args = line.Replace(" ", "").Split(',');
            
            return args;
        }

        internal string[] ReadArgs()
        {
            return Console.ReadLine().Split(' ');
        }
    }
}
