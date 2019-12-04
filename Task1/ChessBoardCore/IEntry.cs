using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ChessBoardCore.Enums;

namespace Tasks.ChessBoardCore {
    interface IEntry 
    {
        EntryColor EntryColor { get; set; }
    }
}
