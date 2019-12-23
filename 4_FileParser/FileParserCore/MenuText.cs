using System;
using System.Collections.Generic;
using System.Text;

namespace _4_FileParser.FileParserCore
{
    class MenuText
    {
        public const string MENU_REPLACE_COMMAND= "/replace";
        public const string MENU_COUNT_COMMAND = "/count";
        public const string MENU_RESULT_COUNT_OF_STRINGS = "count of strings";

        public const string MENU_CURRENT_STRING_PARAM = "{current string}";
        public const string MENU_REPLACE_STRING_PARAM = "{replace string}";
        public const string MENU_PATH_PARAM = "{path}";

        public static string MENU_COUNT_DESCRIPTION = " - calculate count of string in file";
        public static string MENU_REPLACE_DESCRIPTION = " - replace string";
    }
}
