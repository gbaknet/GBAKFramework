//GBAKFramework open source database processing
namespace GBAK
{
	using System;
	using System.Linq;
	using System.Data.Linq;
	public partial class MyLocalDBConnection:IDisposable
	{
		public int CommandTimeout { get; set; } = 30;
		public SELECT Select { get; private set; }
		public EXEC Exec { get; private set; }
		DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection);
		public MyLocalDBConnection()
		{
			d.CommandTimeout = CommandTimeout;
			d.ExecuteCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;");
			Select = new SELECT(ref d);
			Exec = new EXEC(ref d);
		}
		public void Dispose()
		{
			d.Dispose();
		}
		public class SELECT
        {
            DataContext d;
            public SELECT(ref DataContext d)
            {
                this.d = d;
            }
			public IQueryable<MyLocalDBConnection.Tables.People> People()
			{
				return d.GetTable<MyLocalDBConnection.Tables.People>();
			}
			public IQueryable<MyLocalDBConnection.Tables.PeopleProperties> PeopleProperties()
			{
				return d.GetTable<MyLocalDBConnection.Tables.PeopleProperties>();
			}
        }
	}
}


