using SqlQueryGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator.JoinOperator
{
    public abstract class JoinOperator
    {
        public string GenerateJoinQuery(Join joinParam, string primaryTableName)
        {
            return $" {joinParam.Type} {joinParam.SecondaryTableName} AS" +
                $" {joinParam.SecondaryTableName} ON {primaryTableName}.{joinParam.JoinOnColumn}" +
                $" = {joinParam.SecondaryTableName}.{joinParam.JoinOnColumn}";
        }

    }
}
