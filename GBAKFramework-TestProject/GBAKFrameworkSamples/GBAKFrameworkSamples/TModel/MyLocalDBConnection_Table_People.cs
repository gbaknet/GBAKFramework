//GBAKFramework open source database processing
using System;
using System.Linq;
using System.Data.Linq.Mapping;
namespace GBAK.MyLocalDBConnection
{
	public partial class Tables{
		[Table(Name = "People")]
		public class People: BS
		{
			[Column(Name = "Id")]
			public int Id { get; set; }
 
			[Column(Name = "name")]
			public string name { get; set; }
 
			[Column(Name = "surname")]
			public string surname { get; set; } = null;
 
			[Column(Name = "age")]
			public byte? age { get; set; } = null;
 
			[Column(Name = "female")]
			public bool? female { get; set; } = null;
			public Relation Relations()
            {
                People k = new People();
                
                k.Id = Id;
                k.name = name;
                k.surname = surname;
                k.age = age;
                k.female = female;
                return new Relation(ref k);
            }
            public class Relation : IDisposable
            {
                People k = new People();
                SELECT N = new SELECT();
                public Relation(ref People k)
                {
                    this.k = k;
                }
                public void Dispose()
                {
                    N.Dispose();
                }
				public IQueryable<Tables.PeopleProperties> PeopleProperties()
                {
                    return N.PeopleProperties().Where(z => z.personID == k.Id);
                }
                
            }
		}
		[Table(Name = "People")]
		public class TableAfterTrigger_People
		{
			[Column(Name = "Inserted_Id")]
			public int Inserted_Id { get; set; }
			[Column(Name = "Deleted_Id")]
			public int Deleted_Id { get; set; }
			[Column(Name = "Inserted_name")]
			public string Inserted_name { get; set; }
			[Column(Name = "Deleted_name")]
			public string Deleted_name { get; set; }
			[Column(Name = "Inserted_surname")]
			public string Inserted_surname { get; set; }
			[Column(Name = "Deleted_surname")]
			public string Deleted_surname { get; set; }
			[Column(Name = "Inserted_age")]
			public byte? Inserted_age { get; set; }
			[Column(Name = "Deleted_age")]
			public byte? Deleted_age { get; set; }
			[Column(Name = "Inserted_female")]
			public bool? Inserted_female { get; set; }
			[Column(Name = "Deleted_female")]
			public bool? Deleted_female { get; set; }
	
		}
	}
}    
