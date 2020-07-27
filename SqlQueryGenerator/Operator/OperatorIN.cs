using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlQueryGenerator.Interfaces;
using SqlQueryGenerator.Models;

namespace SqlQueryGenerator.Operator
{
    public class OperatorIN : IOperator
    {
        public string GenerateQuery(Column queryParameter)
        {
            return $"{queryParameter.FieldName} IN ({queryParameter.FieldValue})";
        }
    }
}
