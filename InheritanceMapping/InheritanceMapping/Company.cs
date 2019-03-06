using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping
{
    class Company:Party
    {
        public virtual int EmployeeID { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual int CompanyID { get; set; }
        public virtual string CompanyName { get; set; }
    }
}
