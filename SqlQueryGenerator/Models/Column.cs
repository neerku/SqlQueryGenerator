using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator.Models
{
   public class Column
    {
        public string SqlOperator { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public string FieldType { get; set; }
    }

    public enum SqlType
    {
        sqlInt,
        sqlGuid,
        sqlString
    }
}
