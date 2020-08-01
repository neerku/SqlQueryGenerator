using SqlQueryGenerator.Interfaces;
using SqlQueryGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator.Operator
{
       public class OperatorBetween : Operator, IOperator
        {
            public string GenerateQuery(Column queryParameter)
            {
            var updatedParams = this.GetFieldValue(queryParameter);
            var betweenList = queryParameter.FieldValue.Split(';').ToList();
           
                return $"{queryParameter.FieldName} BETWEEN {betweenList.FirstOrDefault()} AND {betweenList.LastOrDefault()} ";
            }
        }
    
}
