using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace InheritanceMapping
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);
            Map(x => x.NationalIdentityNumber);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.PhoneNumber);
            Map(x => x.Address);
            Map(x => x.Birthdate);
            Map(x => x.EmailAddress);
            
        }
    }
}
