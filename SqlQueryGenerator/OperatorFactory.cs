using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlQueryGenerator.Interfaces;
using SqlQueryGenerator.Operator;

namespace SqlQueryGenerator
{
   public class OperatorFactory
    {
        public IOperator GetOperator(string operatorType)
        {
            if (string.Equals(operatorType, "Equal", StringComparison.OrdinalIgnoreCase))
            {
                return new OperatorEqual();
            }
            else if (string.Equals(operatorType, "IN", StringComparison.OrdinalIgnoreCase))
            {
                return new OperatorIN();
            }
            return null;
        }
    }
}
