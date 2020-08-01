using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlQueryGenerator.Interfaces;
using SqlQueryGenerator.Models;

namespace SqlQueryGenerator.Operator
{
    public class OperatorEqual : Operator, IOperator
    {
        public string GenerateQuery(Column queryParameter)
        {
            var updatedValue = this.GetFieldValue(queryParameter);

            return $"{queryParameter.FieldName} = {updatedValue.FieldValue}";
        }
    }
}
