using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TablePerTypeCF
{
    //[Table("PermanentEmployee")]
    public class PermanentEmployee : Employee
    {
        public int AnnualSalary { get; set; }
    }
}