using SqlQueryGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator.Interfaces
{
   public interface IOperator
    {
        string GenerateQuery(Column queryParam);
    }
}
