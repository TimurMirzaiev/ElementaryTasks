using _4_FileParser.FileParserCore;
using _4_FileParser.FileParserCore.ConsoleUI;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _4_FileParser
{
    class FileParserApp
    {
        private FileParser _fileParser;
        private ParserArguments _parserArguments;

        public FileParserApp()
        {
            _fileParser = new FileParser();
            _parserArguments = new ParserArguments();
        }

        public void Run(string[] args)
        {
            bool isExit = false;

            while (isExit == false)
            {
                FileParserUI fileParserUI = new FileParserUI();
                FileParser fileParser = new FileParser();

                string command = string.Empty;
                bool isValid = false;

                if (args.Length == 1)
                {
                    command = args[0].ToLower();
                }

                switch (command)
                {
                    case MenuText.MENU_COUNT_COMMAND:
                    {
                        int count = 0;
                        try
                        {
                            args = fileParserUI.ReadArgs();
                            isValid = _parserArguments.IsValidCommandCounting(args);

                            if (isValid)
                            {
                                count = fileParser.Count(args[0], args[1]);
                                fileParserUI.ShowCountOfStrings(count);
                            }
                            else
                            {
                                throw new ArgumentException();
                            }
                        }
                        catch (FormatException ex)
                        {
                            //
                        }
                        catch(IOException ex)
                        {
                            //
                        }

                        break;
                    }
                    case MenuText.MENU_REPLACE_COMMAND:
                    {
                        int count = 0;
                        try
                        {
                            args = fileParserUI.ReadArgs();
                            isValid = _parserArguments.IsValidCommandReplace(args);

                            if (isValid)
                            {
                                fileParser.Replace(args[0], args[1], args[2]);
                            }
                            else
                            {
                                throw new ArgumentException();
                            }
                        }
                        catch (FormatException ex)
                        {
                            //
                        }
                        catch (IOException ex)
                        {
                            //
                        }

                        break;
                    }
                    default:
                    {
                        fileParserUI.ShowMenu();
                        break;
                    }
                }

                args = fileParserUI.ReadArgs();
            }
        }
    }
}
