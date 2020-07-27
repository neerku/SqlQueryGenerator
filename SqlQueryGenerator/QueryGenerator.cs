using SqlQueryGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator
{
   public class QueryGenerator
    {
        public string GenerateQuery(PrimaryTable input)
        {
            StringBuilder query = new StringBuilder("Select * From ");

            query.Append(input.Name + " Where ");
            for (int i = 0; i < input.Columns.Count(); i++)
            {
                var queryParameter = input.Columns[i];

                var operatorFactory = new OperatorFactory();
                var operatorType = operatorFactory.GetOperator(queryParameter.SqlOperator);
                var generatedQuery = operatorType.GenerateQuery(queryParameter);

                query.Append(generatedQuery);

                if (i < input.Columns.Count() - 1)
                    query.Append(" and ");
            }
            return query.ToString();
        }
    }
}
