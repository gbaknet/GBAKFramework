//GBAKFramework open source database processing
using System;
using System.Data.Linq;
namespace GBAK.MyLocalDBConnection
{
	public partial class Tables{
		public class SELECT: IDisposable
		{
			DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection);
			public SELECT(){
				d.CommandTimeout = MyLocalDBConnection.Tables.CommandTimeout;
				d.ExecuteCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;");
			}
			public void Dispose()
			{
				d.Dispose();
			}
			public Table<MyLocalDBConnection.Tables.Table> Table()
			{
				return d.GetTable<MyLocalDBConnection.Tables.Table>();
			}
		}
	}
}

