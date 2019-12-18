using System;

namespace _3_Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            TrianglesApp trianglesApp = new TrianglesApp();
            trianglesApp.Run(args);
        }
    }
}
