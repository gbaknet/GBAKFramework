//GBAKFramework open source database processing
using System;
using System.Collections.Generic;
namespace GBAK.MyLocalDBConnection
{
	public partial class SP
	{
		public class get_table
		{
			public IList<get_table_Result1> Result1 { get; set; }
			//public int? param1  { get; set; } = 0;
		}
		public class get_table_Result1
		{
			public int? Id  { get; set; }
			public string name  { get; set; }
			public string surname  { get; set; }
			public byte? age  { get; set; }
			public bool? female  { get; set; }
		}
	}

}
