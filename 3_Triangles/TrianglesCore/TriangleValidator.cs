using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Triangles.TrianglesCore
{
    class TriangleValidator: AbstractValidator<Triangle>
    {
        public TriangleValidator()
        {
            RuleFor(t => t.Name).NotEmpty();

            RuleFor(t => t.SideA)
                .LessThan(t => t.SideB + t.SideC)
                .LessThan(double.MaxValue);

            RuleFor(t => t.SideB)
                .LessThan(t => t.SideA + t.SideC)
                .LessThan(double.MaxValue);

            RuleFor(t => t.SideC)
                .LessThan(t => t.SideA + t.SideB)
                .LessThan(double.MaxValue);

        }
    }
}
