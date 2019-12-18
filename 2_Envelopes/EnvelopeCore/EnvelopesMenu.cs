using _2_Envelopes.EnvelopeCore.MenuStrings;
using _2_Envelopes.EnvelopeCore.Validator;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Envelopes.EnvelopeCore
{
    class EnvelopesMenu: IConsoleMenu
    {
        private EnvelopeValidator _envelopeValidator;

        public EnvelopesMenu()
        {
            _envelopeValidator = new EnvelopeValidator();
        }

        public void ShowMenu()
        {
            StringBuilder menuText = new StringBuilder();
            menuText.Append(EnvelopesMenuText.MENU_COMPARE_COMMAND);
            menuText.Append(EnvelopesMenuText.MENU_COMPARE_DESCRIPTION);

            Console.WriteLine(menuText.ToString());
        }

        public double ReadSide()
        {
            string line = Console.ReadLine();
            double side;

            try
            {
                side = Convert.ToDouble(line);
                
                if (side > 0)
                {
                    return side;
                }
                
                return ReadSide();
            }
            catch(FormatException ex)
            {
                //
            }
            catch(OverflowException ex)
            {
                //
            }

            return ReadSide();
        }

        internal void ShowComparableResult(bool result)
        {
            if (result)
            {
                Console.WriteLine(EnvelopesMenuText.ENVELOPES_ARE_PACKABLES);
            }
            else
            {
                Console.WriteLine(EnvelopesMenuText.ENVELOPES_ARE_NOT_PACKABLES);
            }
        }

        public string ReadCommand()
        {
            return Console.ReadLine();
        }
    }
}
