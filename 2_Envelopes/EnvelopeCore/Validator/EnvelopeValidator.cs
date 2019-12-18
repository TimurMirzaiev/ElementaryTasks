using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Envelopes.EnvelopeCore.Validator
{
    class EnvelopeValidator : AbstractValidator<Envelope>
    {
        public EnvelopeValidator()
        {
            RuleFor(t => t.SideA > 0 && t.SideB > 0);
        }
    }
}
