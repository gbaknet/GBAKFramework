//GBAKFramework open source database processing
using System;
namespace GBAK.MyLocalDBConnection
{
	public partial class Tables
    {
        public static GBAK.Error Add(MyLocalDBConnection.Tables.Table values, out int? Id)
        {
			return Engine.Table_Table.Add(out Id, values);
        }
		public static GBAK.Error Add(MyLocalDBConnection.Tables.Table values)
        {
			int? Id = null;
			return Engine.Table_Table.Add(out Id, values);
        }
    }
}
