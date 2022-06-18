using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.SolidPrinciples
{
    //Validation sınıfının alt sınıflara olan bağımlılığını IOperationValidation interface'i sayesinde kaldırmış olduk.
    public interface IOperationValidation
    {
        bool IsValid(int a, int b);
    }
    public class SumValidation : IOperationValidation
    {
        public bool IsValid(int a, int b)
        {
            return a < 0 || b < 0
                    ? false
                    : true;
        }
    }
    public class DivideValidation : IOperationValidation
    {
        public bool IsValid(int a, int b)
        {
            return a == 0 || b == 0
                   ? true
                   : false;
        }
    }
    public class Validation
    {
        private IOperationValidation operationValidation;
        public Validation(IOperationValidation _operationValidation)
        {
            operationValidation = _operationValidation;
        }
        public bool IsValid(int a, int b)
        {
            return operationValidation.IsValid(a, b);
        }
    }
}
