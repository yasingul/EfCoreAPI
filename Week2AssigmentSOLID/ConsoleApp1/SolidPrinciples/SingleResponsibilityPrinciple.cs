using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples.SolidPrinciples
{
    public class SingleResponsibilityPrinciple
    {
        const string ErrorMessage = "Input is not valid";
        ValidationClass validation = new ValidationClass();
        public int Sum(int a, int b)
        {
            if (!validation.IsValid(a,b))
            {
                throw new Exception(ErrorMessage);

            }
            return a + b;
        }
        public class ValidationClass
        {
            public bool IsValid(int a, int b)
            {
                return a<0 || b<0
                    ? false
                    :true;
            }
        }
    }
}
