//GBAKFramework open source database processing
using System;
namespace GBAK.MyLocalDBConnection
{
	public partial class Tables
    {
        public static GBAK.Error Add(MyLocalDBConnection.Tables.Table values)
        {
			return Engine.Table_Table.Add(values);
        }
    }
}
