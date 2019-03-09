using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping
{
    public class PartyMap : ClassMap<Party>
    {
        public PartyMap()
            {
                Table("Party");
                Id(x => x.Id, "intId");
                Map(x => x.EmailAddress);
                Map(x => x.Address);
                Map(x => x.PhoneNumber);
                DiscriminateSubClassesOnColumn("Type").Not.Nullable();
            }
    }
}

