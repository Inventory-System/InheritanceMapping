using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var assinstin = FluentNHibernateHelper.OpenSesseion())
            { 
            }
            Console.ReadKey();
        }
    }
}
