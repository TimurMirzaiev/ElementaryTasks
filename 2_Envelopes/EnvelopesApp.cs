using _2_Envelopes.EnvelopeCore;
using _2_Envelopes.EnvelopeCore.MenuStrings;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Envelopes
{
    class EnvelopesApp
    {
        private readonly EnvelopesMenu _envelopesMenu;

        public EnvelopesApp()
        {
            _envelopesMenu = new EnvelopesMenu();
        }

        public void Run(string[] args)
        {
            bool isExit = false;
            string command = string.Empty;

            while (isExit == false)
            {
                if (args.Length != 0)
                {
                    command = args[0].ToLower();
                }

                switch (command)
                {
                    case EnvelopesMenuText.MENU_COMPARE_COMMAND:
                    {
                        
                        AnalyzerEnvelopes analyzerEnvelopes = new AnalyzerEnvelopes();
                        
                        try
                        {
                            Console.WriteLine(EnvelopesMenuText.ENTER_DATA);
                            Console.Write(EnvelopesMenuText.ENTER_SIDE_A);
                            double a = _envelopesMenu.ReadSide();
                            Console.Write(EnvelopesMenuText.ENTER_SIDE_B);
                            double b = _envelopesMenu.ReadSide();
                            Console.Write(EnvelopesMenuText.ENTER_SIDE_C);
                            double c = _envelopesMenu.ReadSide();
                            Console.Write(EnvelopesMenuText.ENTER_SIDE_D);
                            double d = _envelopesMenu.ReadSide();

                            Envelope first = Envelope.CreateEnvelope(a, b);
                            Envelope second = Envelope.CreateEnvelope(c, d);

                            bool result = analyzerEnvelopes.IsPackable(first, second);

                            _envelopesMenu.ShowComparableResult(result);
                        }
                        catch (ArgumentException ex)
                        {
                            _envelopesMenu.ShowMenu();
                            //
                        }
                        
                        break;
                    }
                    case EnvelopesMenuText.MENU_EXIT_COMMAND:
                    {
                        isExit = true;
                        break;
                    }
                    default:
                    {
                        _envelopesMenu.ShowMenu();
                        break;
                    }
                }

                command = _envelopesMenu.ReadCommand();
            }
        }
    }
}
