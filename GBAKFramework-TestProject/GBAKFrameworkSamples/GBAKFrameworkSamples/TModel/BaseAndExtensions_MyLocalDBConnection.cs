//GBAKFramework open source database processing
using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using GBAK.Engine;
public static class Extensions_MyLocalDBConnection
{
	public static bool Remove(this IQueryable<GBAK.MyLocalDBConnection.Tables.People> value)
    {
		return GBAK.MyLocalDBConnection.Engine.Table_People.DELETE(value as IQueryable<GBAK.MyLocalDBConnection.Tables.People>);
		return false;
	}
	public static bool Save(this GBAK.MyLocalDBConnection.Tables.People value) 
    {
        //string TableName = typeof(T).GetAttributeValue((TableAttribute dna) => dna.Name);
		//if(TableName=="People") 
		return GBAK.MyLocalDBConnection.Engine.Table_People.UPDATE(value as GBAK.MyLocalDBConnection.Tables.People);
        return false;
    }
   
	public static bool Remove(this IQueryable<GBAK.MyLocalDBConnection.Tables.PeopleProperties> value)
    {
		return GBAK.MyLocalDBConnection.Engine.Table_PeopleProperties.DELETE(value as IQueryable<GBAK.MyLocalDBConnection.Tables.PeopleProperties>);
		return false;
	}
	public static bool Save(this GBAK.MyLocalDBConnection.Tables.PeopleProperties value) 
    {
        //string TableName = typeof(T).GetAttributeValue((TableAttribute dna) => dna.Name);
		//if(TableName=="PeopleProperties") 
		return GBAK.MyLocalDBConnection.Engine.Table_PeopleProperties.UPDATE(value as GBAK.MyLocalDBConnection.Tables.PeopleProperties);
        return false;
    }
   
	
}



