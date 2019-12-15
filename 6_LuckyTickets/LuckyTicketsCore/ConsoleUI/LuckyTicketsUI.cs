using _6_LuckyTickets.LuckyTicketsCore.ConsoleUI.MenuStrings;
using _6_LuckyTickets.LuckyTicketsCore.Model;
using Common.Interfaces;
using System;
using System.IO;
using System.Text;

namespace _6_LuckyTickets.LuckyTicketsCore.ConsoleUI
{
    public class LuckyTicketsUI : IConsoleMenu
    {
        public void ShowMenu()
        {
            string isLuckyCommand = string.Format("{0} {1}",
                   LuckyTicketsMenuText.MENU_LUCKY_COMMAND,
                   LuckyTicketsMenuText.MENU_LUCKY_DESCRIPTION);

            string exitCommand = string.Format("{0} {1}",
                   LuckyTicketsMenuText.MENU_EXIT_COMMAND,
                   LuckyTicketsMenuText.MENU_EXIT_DESCRIPTION);

            StringBuilder res = new StringBuilder();

            res.AppendLine(isLuckyCommand);
            res.AppendLine(exitCommand);

            Console.WriteLine(res.ToString());
        }

        public string[] ReadArgs()
        {
            return Console.ReadLine()?.Split(' ');
        }

        public void Show(string text)
        {
            Console.WriteLine(text);
        }

        public Alghorithm ReadAlghoritmByPath()
        {
            Console.Write(LuckyTicketsMenuText.ENTER_PATH_DESCRIPTION);
            string line;
            string path;
            Alghorithm alghorithm;

            path = GetPathByReadLine();
            line = GetAlghorithmFromFile(path);

            switch (line)
            {
                case LuckyTicketsMenuText.MOSCOW_ALGHORITHM:
                {
                    alghorithm = Alghorithm.Moscow;
                    break;
                }
                case LuckyTicketsMenuText.PITER_ALGHORITHM:
                {
                    alghorithm = Alghorithm.Piter;
                    break;
                }
                default:
                    alghorithm = Alghorithm.None;
                    break;
            }

            return alghorithm;
        }

        private string GetAlghorithmFromFile(string path)
        {
            string line = String.Empty;

            if (path != null)
            {
                using(StreamReader reader = new StreamReader(path))
                {
                    line = reader.ReadLine() ?? "";
                }
            }

            return line;
        }

        private string GetPathByReadLine()
        {
            return Console.ReadLine() ?? "";
        }
    }
}
