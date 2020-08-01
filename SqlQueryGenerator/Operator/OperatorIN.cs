using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlQueryGenerator.Interfaces;
using SqlQueryGenerator.Models;

namespace SqlQueryGenerator.Operator
{
    public class OperatorIN : Operator, IOperator
    {
        public string GenerateQuery(Column queryParameter)
        {
            var updatedParameter = this.GetFieldValue(queryParameter);
            return $"{queryParameter.FieldName} IN ({updatedParameter.FieldValue})";
        }
    }
}
