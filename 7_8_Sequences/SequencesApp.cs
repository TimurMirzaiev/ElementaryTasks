using _7_8_Sequences.SequencesCore;
using _7_8_Sequences.SequencesCore.ConsoleUI;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _7_8_Sequences
{
    class SequencesApp
    {
        ParserArguments _parserArguments = new ParserArguments();

        public SequencesApp()
        {
            _parserArguments = new ParserArguments();
        }

        public void Run(string[] args)
        {
            bool isExit = false;

            while (isExit == false)
            {
                SequencesUI sequencesUI = new SequencesUI();
                SequenceAnalyzer 
                string command = string.Empty;
                bool isValid = false;

                if (args.Length != 0)
                {
                    command = args[0].ToLower();
                }

                switch (command)
                {
                    case MenuText.MENU_SQUARE_LESS_THAN_N_COMMAND:
                    {
                        args = sequencesUI.ReadArgs();
                        isValid = _parserArguments.IsValidCommandSquareLessThan(args);
                        

                        sequencesUI.ShowMenu();
                        break;
                    }
                    case MenuText.MENU_RANGE_FIBONACCI_COMMAND:
                    {
                        args = sequencesUI.ReadArgs();
                        isValid = _parserArguments.IsValidCommandFibonaccy(args);


                        sequencesUI.ShowMenu();
                        break;
                    }
                    case MenuText.MENU_EXIT_COMMAND:
                    {
                        isExit = true;
                        break;
                    }
                    default:
                    {
                        sequencesUI.ShowMenu();
                        break;
                    }
                }

                args = sequencesUI.ReadArgs();
            }
        }
    }
}
