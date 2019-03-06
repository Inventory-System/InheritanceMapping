using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;

namespace InheritanceMapping
{
    public class CompanyMap:ClassMap<Company>
    {
        public CompanyMap() 
        {
            Id(x => x.Id);
            Map(x => x.CompanyID);
            Map(x => x.CompanyName);
            Map(x => x.EmployeeID);
            Map(x => x.EmployeeName);
            Map(x => x.EmailAddress);
            Map(x => x.Address);
            Map(x => x.JobTitle);
            Map(x => x.PhoneNumber);

            
        }
    }
}
