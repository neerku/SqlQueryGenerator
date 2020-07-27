using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator.Models
{
    public class PrimaryTable
    {
        public List<Column> Columns { get; set; }
        public string Name { get; set; }
    }
}
