//GBAKFramework open source database processing
using System.Data.SqlClient;
namespace GBAK.Engine
{
    public static class PublicVariable
    {
		
				public static string Connection_MyLocalDBConnection = System.Configuration.ConfigurationManager.ConnectionStrings["Connection_MyLocalDBConnection"].ConnectionString;
			}
}

