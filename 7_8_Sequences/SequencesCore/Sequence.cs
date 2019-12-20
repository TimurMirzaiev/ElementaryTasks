using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _7_8_Sequences.SequencesCore
{
    class Sequence : IEnumerable<int>
    {


        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
