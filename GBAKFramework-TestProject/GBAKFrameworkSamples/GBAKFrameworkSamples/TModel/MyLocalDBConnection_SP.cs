//GBAKFramework open source database processing
using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
namespace GBAK.MyLocalDBConnection
{
	public partial class SP{
		public class EXEC: IDisposable
		{
			//DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection);
			public EXEC(){
				//d.CommandTimeout = MyLocalDBConnection.Tables.CommandTimeout;
			}
			public void Dispose()
			{
				//d.Dispose();
			}
			public SP.get_table get_table(int? param1 = 0)
			{
				System.Data.SqlClient.SqlParameter[] param = new System.Data.SqlClient.SqlParameter[0];
                int i2 = 0;
                if ((param1) != null) { Array.Resize(ref param, i2 + 1); param[i2] = new System.Data.SqlClient.SqlParameter("@param1", param1); i2 = i2 + 1; }
				System.Data.DataSet ds = Engine.ExecutionModel.Exec("get_table", param);
				SP.get_table temp = new SP.get_table();
				List<SP.get_table_Result1> get_table_Result1 = new List<SP.get_table_Result1>();
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					get_table_Result1.Add(new SP.get_table_Result1
					{
						Id = (ds.Tables[0].Rows[i]["Id"] is DBNull ? null : (int?)Convert.ToInt32(ds.Tables[0].Rows[i]["Id"])),
						name = (ds.Tables[0].Rows[i]["name"] is DBNull ? null : (string)Convert.ToString(ds.Tables[0].Rows[i]["name"])),
						surname = (ds.Tables[0].Rows[i]["surname"] is DBNull ? null : (string)Convert.ToString(ds.Tables[0].Rows[i]["surname"])),
						age = (ds.Tables[0].Rows[i]["age"] is DBNull ? null : (byte?)Convert.ToByte(ds.Tables[0].Rows[i]["age"])),
						female = (ds.Tables[0].Rows[i]["female"] is DBNull ? null : (bool?)Convert.ToBoolean(ds.Tables[0].Rows[i]["female"])),
					});
				}
				temp.Result1 = get_table_Result1;
				return temp;
			}
		}
	}
}
