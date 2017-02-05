//GBAKFramework open source database processing
using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using GBAK.Engine;
public static class Extensions_MyLocalDBConnection
{
/*	public static bool Remove<T>(this IQueryable<T> value) where T : GBAK.MyLocalDBConnection.Tables.BS
    {
        string TableName = typeof(T).GetAttributeValue((TableAttribute dna) => dna.Name);

		if(TableName=="Table") return GBAK.MyLocalDBConnection.Engine.Table_Table.DELETE(value as IQueryable<GBAK.MyLocalDBConnection.Tables.Table>);

        return false;
    }
*/
	public static bool Remove(this IQueryable<GBAK.MyLocalDBConnection.Tables.Table> value)
    {
		return GBAK.MyLocalDBConnection.Engine.Table_Table.DELETE(value as IQueryable<GBAK.MyLocalDBConnection.Tables.Table>);
		return false;
	}
	public static bool Save(this GBAK.MyLocalDBConnection.Tables.Table value) 
    {
        //string TableName = typeof(T).GetAttributeValue((TableAttribute dna) => dna.Name);
		//if(TableName=="Table") 
		return GBAK.MyLocalDBConnection.Engine.Table_Table.UPDATE(value as GBAK.MyLocalDBConnection.Tables.Table);
        return false;
    }
   
	
}
namespace GBAK.MyLocalDBConnection
{
	public partial class Tables{
		public class BS { }
	}
	public partial class SP{
		public class SS { }
	}
}
