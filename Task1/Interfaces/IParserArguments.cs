using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Interfaces {
    public interface IParserArguments {
        public bool IsValid(string[] args, bool skipFirstArgument = false);
    }
}
