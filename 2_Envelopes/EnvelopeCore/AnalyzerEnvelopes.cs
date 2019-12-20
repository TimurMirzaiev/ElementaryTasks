using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Envelopes.EnvelopeCore
{
    class AnalyzerEnvelopes
    {
        public bool IsPackable(Envelope a, Envelope b)
        {
            int res = a.CompareTo(b);
            bool isPackable = false;

            if(res != 0)
            {
                isPackable = true;
            }

            return isPackable;
        }
    }
}
