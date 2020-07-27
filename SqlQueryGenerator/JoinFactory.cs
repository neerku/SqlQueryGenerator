using SqlQueryGenerator.Interfaces;
using SqlQueryGenerator.JoinOperator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator
{
    public class JoinFactory
    {
        public IJoinOperator GetJoinOperator(String operatorType)
        {
            if (string.Equals(operatorType, "LEFT JOIN", StringComparison.OrdinalIgnoreCase))
            {
                return new LeftJoin();
            }
            else if (string.Equals(operatorType, "RIGHT JOIN", StringComparison.OrdinalIgnoreCase))
            {
                return new RightJoin();
            }
            return null;
        }

    }
}
