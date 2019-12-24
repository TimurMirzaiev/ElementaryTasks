using Serilog;
using System;
using System.IO;
using _4_FileParser.FileParserCore;
using _4_FileParser.FileParserCore.ConsoleUI;

namespace _4_FileParser
{
    public class FileParserApp
    {
        private readonly IFileParser _fileParser;
        private readonly FileParserUI _fileParserUI;
        private readonly ParserArguments _parserArguments;

        public FileParserApp(IFileParser fileParser)
        {
            _fileParser = fileParser;
            _fileParserUI = new FileParserUI();
            _parserArguments = new ParserArguments();
        }

        public void Run(string[] args)
        {
            bool isExit = false;

            while (isExit == false)
            {
                string command = string.Empty;
                bool isValid;

                if (args.Length == 1)
                {
                    command = args[0].ToLower();
                }

                switch (command)
                {
                    case MenuText.MENU_COUNT_COMMAND:
                    {
                        _fileParserUI.ShowCountCommandParams();

                        try
                        {
                            args = _fileParserUI.ReadArgs();
                            isValid = _parserArguments.IsValidCommandCounting(args);

                            if (isValid)
                            {
                                try
                                {
                                    int count = _fileParser.Count(args[0], args[1]);
                                    Log.Logger.Information("Calculate count of string is executed correctly");
                                    _fileParserUI.ShowCountOfStrings(count);
                                }
                                catch (ArgumentException ex)
                                {
                                    Log.Logger.Error("ArgumentException: {0}", ex.Message);
                                }
                            }
                            else
                            {
                                Log.Logger.Error("Invalid arguments for command {0}",
                                    MenuText.MENU_COUNT_COMMAND);
                            }
                        }
                        catch (FormatException ex)
                        {
                            Log.Logger.Error("FormatException: {0}", ex.Message);
                        }
                        catch (IOException ex)
                        {
                            Log.Logger.Error("IOException: {0}", ex.Message);
                        }

                        _fileParserUI.ShowMenu();
                        break;
                    }
                    case MenuText.MENU_REPLACE_COMMAND:
                    {
                        _fileParserUI.ShowReplaceCommandParams();

                        try
                        {
                            args = _fileParserUI.ReadArgs();
                            isValid = _parserArguments.IsValidCommandReplace(args);

                            if (isValid)
                            {
                                try
                                {
                                    _fileParser.Replace(args[0], args[1], args[2]);
                                    Log.Logger.Information("Replace string is executed correctly");
                                    _fileParserUI.ShowReplaceIsOk();
                                }
                                catch (ArgumentException ex)
                                {
                                    Log.Logger.Error("ArgumentException: {0}", ex.Message);
                                }
                            }
                            else
                            {
                                Log.Logger.Error("Invalid arguments for command {0}",
                                    MenuText.MENU_COUNT_DESCRIPTION);
                            }
                        }
                        catch (FormatException ex)
                        {
                            Log.Logger.Error("FormatException: {0}", ex.Message);
                        }
                        catch (IOException ex)
                        {
                            Log.Logger.Error("IOException: {0}", ex.Message);
                        }

                        _fileParserUI.ShowMenu();
                        break;
                    }
                    case MenuText.MENU_EXIT_COMMAND:
                    {
                        isExit = true;
                        break;
                    }
                    default:
                    {
                        Log.Logger.Error("Invalid arguments");
                        _fileParserUI.ShowMenu();
                        break;
                    }
                }

                args = _fileParserUI.ReadArgs();
            }
        }
    }
}
