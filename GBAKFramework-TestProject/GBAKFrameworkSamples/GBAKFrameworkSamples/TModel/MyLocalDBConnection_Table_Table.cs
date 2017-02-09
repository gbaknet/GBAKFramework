//GBAKFramework open source database processing
using System;
using System.Data.Linq.Mapping;
namespace GBAK.MyLocalDBConnection
{
	public partial class Tables{
		[Table(Name = "Table")]
		public class Table: BS
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
		}
		[Table(Name = "Table")]
		public class TableAfterTrigger_Table
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
