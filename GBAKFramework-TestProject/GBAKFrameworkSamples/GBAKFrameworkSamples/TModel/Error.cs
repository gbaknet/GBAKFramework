//GBAKFramework open source database processing
using System;
 
namespace GBAK
{
	public class Error{
		public bool Status { get; set; } = false;
		public string Description { get; set; } = "Successful";
		public void SETNotNullable(string value)
        {
            Description = "The \"" + value + "\" field can not be null.";
        }
	}
}
