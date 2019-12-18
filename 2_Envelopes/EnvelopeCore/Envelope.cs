using _2_Envelopes.EnvelopeCore.Validator;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _2_Envelopes.EnvelopeCore
{
    class Envelope: IComparable<Envelope>
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        private Envelope(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public static Envelope CreateEnvelope(double a, double b)
        {
            EnvelopeValidator envelopeValidator = new EnvelopeValidator();
            ValidationResult validationResult = envelopeValidator.Validate(new Envelope(a, b));

            if (validationResult.IsValid)
            {
                return new Envelope(a, b);
            }

            throw new ArgumentException("Invalid arguments for envelope");
        }

        public int CompareTo(Envelope other)
        {
            int res;

            if( (this.SideA > other.SideA && this.SideB > other.SideB) 
                || (this.SideA > other.SideB && this.SideB > other.SideA) )
            {
                res = 1;
            }
            else
            {
                res = -1;
            }

            if ( (this.SideA == other.SideA && this.SideB == other.SideB) )
            {
                res = 0;
            }

            return res;
        }
    }
}
