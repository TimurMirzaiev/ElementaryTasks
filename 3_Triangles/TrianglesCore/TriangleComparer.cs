using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _3_Triangles.TrianglesCore
{
    class TriangleComparer : IComparer<Triangle>
    {
        public int Compare(Triangle x, Triangle y)
        {
            int res = 0;
            
            if(x.Area > y.Area)
            {
                res = 1;
            }

            if(x.Area < y.Area)
            {
                res = -1;
            }

            if(x.Area == y.Area)
            {
                res = 0;
            }

            return res;
        }
    }
}
