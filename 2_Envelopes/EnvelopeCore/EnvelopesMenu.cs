using _2_Envelopes.EnvelopeCore.MenuStrings;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Envelopes.EnvelopeCore
{
    class EnvelopesMenu: IConsoleMenu
    {
        public void ShowMenu()
        {
            StringBuilder menuText = new StringBuilder();
            menuText.AppendLine(EnvelopesMenuText.MENU_CALCULATE_COMMAND);

            Console.WriteLine(menuText.ToString());
        }
    }
}
