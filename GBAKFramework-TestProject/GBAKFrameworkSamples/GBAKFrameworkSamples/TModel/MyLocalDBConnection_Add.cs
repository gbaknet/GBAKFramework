//GBAKFramework open source database processing
using System;
namespace GBAK
{
	public partial class MyLocalDBConnection
    {
		public partial class Tables
		{
			public partial class People
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
				public static GBAK.Error Add(System.Collections.Generic.List<MyLocalDBConnection.Tables.People> BulkValues)
				{
					return Engine.Table_People.Add(BulkValues);
				}
			}
			public partial class PeopleProperties
			{
				public static GBAK.Error Add(MyLocalDBConnection.Tables.PeopleProperties values, out int? Id)
				{
					return Engine.Table_PeopleProperties.Add(out Id, values);
				}
				public static GBAK.Error Add(MyLocalDBConnection.Tables.PeopleProperties values)
				{
					int? Id = null;
					return Engine.Table_PeopleProperties.Add(out Id, values);
				}
				public static GBAK.Error Add(System.Collections.Generic.List<MyLocalDBConnection.Tables.PeopleProperties> BulkValues)
				{
					return Engine.Table_PeopleProperties.Add(BulkValues);
				}
			}
		}
	}
}





