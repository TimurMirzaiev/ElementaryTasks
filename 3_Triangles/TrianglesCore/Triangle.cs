using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Triangles.TrianglesCore
{
    class Triangle
    {
        private const int DIVIDER_TWO = 2;
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public string Name { get; }
        public double Area { get; private set; }
        public double Perimeter { get; private set; }

        private Triangle(string name, double sideA, double sideB, double sideC)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Perimeter = CalculatePerimeter();
            Area = CalculateArea();
        }

        private double CalculateArea()
        {
            if(Perimeter == 0)
            {
                Perimeter = CalculatePerimeter();
            }

            double halfPerimeter = Perimeter / DIVIDER_TWO;

            return Math.Sqrt(halfPerimeter 
                * (halfPerimeter - SideA)
                * (halfPerimeter - SideB) 
                * (halfPerimeter - SideC));
        }

        private double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public static Triangle CreateTriangle(string name, double sideA, double sideB, double sideC)
        {
            TriangleValidator validator = new TriangleValidator();
            Triangle triangle = new Triangle(name, sideA, sideB, sideC);
            ValidationResult validationResult = validator.Validate(triangle);

            if (validationResult.IsValid)
            {
                return triangle;
            }

            throw new ArgumentException();
        }

        public override string ToString()
        {
            string res = string.Empty;
            res = String.Format("[{0}]: {1} cm", this.Name, this.Area);

            return res;
        }
    }
}
