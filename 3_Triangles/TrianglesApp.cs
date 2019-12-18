using _3_Triangles.TrianglesCore;
using _3_Triangles.TrianglesCore.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Triangles
{
    class TrianglesApp
    {
        private TrianglesUI _trianglesUI;
        private TriangleContainer _triangleContainer;

        public TrianglesApp()
        {
            _trianglesUI = new TrianglesUI();
            _triangleContainer = new TriangleContainer();
        }

        public void Run(string[] args)
        {
            bool isExit = false;
            string[] argsTriangle;

            while (isExit == false)
            {
                TrianglesUI trianglesUI = new TrianglesUI();
                string command = string.Empty;
                string[] continueAnswers = { "y", "yes" };
                string answer = string.Empty;

                if (args.Length != 0)
                {
                    command = args[0].ToLower();
                }

                switch (command)
                {
                    case MenuText.MENU_ADD_TRIANGLE_COMMAND:
                    {
                        do
                        {
                            argsTriangle = _trianglesUI.ReadTriangle();
                            
                            try
                            {
                                string name = argsTriangle[0];
                                double sideA  = Convert.ToDouble(argsTriangle[1]);
                                double sideB = Convert.ToDouble(argsTriangle[2]);
                                double sideC = Convert.ToDouble(argsTriangle[3]);

                                _triangleContainer.AddTriangle(name, sideA, sideB, sideC);
                            }
                            catch (FormatException ex)
                            {
                                //
                            }
                            Console.WriteLine("continue?");
                            answer = Console.ReadLine().ToLower();
                        } while (answer == "y" || answer == "yes");
                        
                        foreach(var triangle in _triangleContainer)
                        {
                            Console.WriteLine(triangle);
                        }

                        break;
                    }
                    case MenuText.MENU_EXIT_COMMAND:
                    {
                        isExit = true;
                        break;
                    }
                    default:
                    {
                        _trianglesUI.ShowMenu();
                        break;
                    }
                }

                args = _trianglesUI.ReadArgs();
            }
        }
    }
}
