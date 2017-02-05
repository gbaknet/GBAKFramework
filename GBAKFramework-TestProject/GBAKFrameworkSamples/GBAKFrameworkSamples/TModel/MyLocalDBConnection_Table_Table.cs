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
	}
}    
