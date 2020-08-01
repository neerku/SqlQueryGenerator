using SqlQueryGenerator.Interfaces;
using SqlQueryGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator.Operator
{
   public abstract class Operator 
    {
         public Column GetFieldValue(Column queryParameter)
        {
            var valueList = queryParameter.FieldValue.Split(';').ToList();
            StringBuilder value = new StringBuilder();
            string output = string.Empty;

            try
            {
                foreach (var item in valueList)
                {
                    switch (queryParameter.FieldType)
                    {
                        case "int":
                            output = queryParameter.FieldType;
                            break;
                        case "datetime":
                            output = DateTime.Parse(queryParameter.FieldValue).ToString("dd-MM-yyyy");
                            break;
                        case "guid":
                            output = Guid.Parse(queryParameter.FieldValue).ToString();
                            break;

                        default:
                            break;
                    }
                    value.Append(output + ";");
                }

                queryParameter.FieldValue = value.ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return queryParameter;

        }
    }
}
