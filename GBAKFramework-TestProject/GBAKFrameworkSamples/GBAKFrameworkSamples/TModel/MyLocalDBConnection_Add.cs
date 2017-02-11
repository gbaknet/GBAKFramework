//GBAKFramework open source database processing
using System;
namespace GBAK.MyLocalDBConnection
{
	public partial class Tables
    {
        public static GBAK.Error Add(MyLocalDBConnection.Tables.People values, out int? Id)
        {
			return Engine.Table_People.Add(out Id, values);
        }
		public static GBAK.Error Add(MyLocalDBConnection.Tables.People values)
        {
			int? Id = null;
			return Engine.Table_People.Add(out Id, values);
        }
        public static GBAK.Error Add(MyLocalDBConnection.Tables.PeopleProperties values, out int? Id)
        {
			return Engine.Table_PeopleProperties.Add(out Id, values);
        }
		public static GBAK.Error Add(MyLocalDBConnection.Tables.PeopleProperties values)
        {
			int? Id = null;
			return Engine.Table_PeopleProperties.Add(out Id, values);
        }
    }
}
