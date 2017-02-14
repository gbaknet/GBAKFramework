//GBAKFramework open source database processing
using System;
using System.Linq;
using System.Data.Linq.Mapping;
namespace GBAK
{
	public partial class MyLocalDBConnection
	{
		public partial class Tables
		{
			[Table(Name = "PeopleProperties")]
			public partial class PeopleProperties
			{
				[Column(Name = "Id")]
				public int Id { get; set; }
				[Column(Name = "personID")]
				public int personID { get; set; }
				[Column(Name = "eyecolor")]
				public string eyecolor { get; set; } = null;
			public Relation Relations()
				{
					PeopleProperties k = new PeopleProperties();
					
                k.Id = Id;
                k.personID = personID;
                k.eyecolor = eyecolor;
					return new Relation(ref k);
				}
				public class Relation : IDisposable
				{
					PeopleProperties k = new PeopleProperties();
					MyLocalDBConnection N = new MyLocalDBConnection();
					public Relation(ref PeopleProperties k)
					{
						this.k = k;
					}
					public void Dispose()
					{
						N.Dispose();
					}
					public IQueryable<Tables.People> People()
					{
						return N.Select.People().Where(z => z.Id == k.personID);
					}
                
				}
			}
			[Table(Name = "PeopleProperties")]
			public class TableAfterTrigger_PeopleProperties
			{
				[Column(Name = "Inserted_Id")]
				public int Inserted_Id { get; set; }
				[Column(Name = "Deleted_Id")]
				public int Deleted_Id { get; set; }
				[Column(Name = "Inserted_personID")]
				public int Inserted_personID { get; set; }
				[Column(Name = "Deleted_personID")]
				public int Deleted_personID { get; set; }
				[Column(Name = "Inserted_eyecolor")]
				public string Inserted_eyecolor { get; set; }
				[Column(Name = "Deleted_eyecolor")]
				public string Deleted_eyecolor { get; set; }
	
			}
		}
	}
}
