using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBAKFrameworkSamples
{
    public static class ExampleForRelations
    {
        public static void Example()
        {
            using (var db = new GBAK.MyLocalDBConnection())
            {
                var spf = db.Select.People().FirstOrDefault();
                var relationtable = spf.Relations().PeopleProperties().FirstOrDefault();
            }
        }
    }
}
