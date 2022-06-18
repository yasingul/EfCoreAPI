using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SolidExamples.SolidPrinciples.SingleResponsibilityPrinciple;

namespace SolidExamples.SolidPrinciples
{
    public interface IOperation
    {
        int Operation(ValidationClass validation, int a, int b);
    }

    public class SumNumbers : IOperation
    {
        public int Operation(ValidationClass validation, int a, int b)
        {
            if (!validation.IsValid(a,b))
            {
                throw new Exception("Input is not valid");
            }
            return a + b;
        }
    }
    public class SubstractNumbers : IOperation
    {
        public int Operation(ValidationClass validation, int a, int b)
        {
            if (!validation.IsValid(a, b))
            {
                throw new Exception("Input is not valid");
            }
            return a - b;
        }
    }

    internal class OpenClosedPrinciple
    {
        private IOperation operation;
        private ValidationClass validation = new ValidationClass();
        public OpenClosedPrinciple(IOperation _operation)
        {
            operation = _operation;
        }
        public int PrenciplesAreGood(int a, int b)
        {
            return operation.Operation(validation, a, b);
        }
    }
}
