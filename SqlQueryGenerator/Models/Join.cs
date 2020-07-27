using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator.Models
{
    public class Join
    {
        public string Type { get; set; }
        public string SecondaryTableName { get; set; }
        public string PrimaryTableColumn { get; set; }
        public string JoinOnColumn { get; set; }

    }
}
