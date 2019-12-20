using _5_NumberInWord.NumberInWordCore;
using _5_NumberInWord.NumberInWordCore.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_NumberInWord
{
    class NumberInWordApp
    {
        public void Run(string[] args)
        {
            bool isExit = false;
            string[] argsTriangle;

            while (isExit == false)
            {
                NumberInWordUI _numberInWordUI = new NumberInWordUI();
                string command = string.Empty;
                string[] continueAnswers = { "y", "yes" };
                string answer = string.Empty;

                if (args.Length != 0)
                {
                    command = args[0].ToLower();
                }

                switch (command)
                {
                    case MenuText.MENU_TRANSFORM_COMMAND:
                    {
                        
                        break;
                    }
                    case MenuText.MENU_EXIT_COMMAND:
                    {
                        isExit = true;
                        break;
                    }
                    default:
                    {
                        _numberInWordUI.ShowMenu();
                        break;
                    }
                }

                args = _numberInWordUI.ReadArgs();
            }
        }
    }
}
