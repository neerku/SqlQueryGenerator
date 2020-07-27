using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator.Models
{
    public class Query
    {
        public PrimaryTable PrimaryTable { get; set; }
        public List<Join> Joins { get; set; }

    }
}
