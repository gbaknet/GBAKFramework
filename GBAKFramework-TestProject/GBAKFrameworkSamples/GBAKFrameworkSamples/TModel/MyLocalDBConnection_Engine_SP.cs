//GBAKFramework open source database processing
using System;
using System.Data.Linq;
using System.Data.SqlClient;
namespace GBAK.MyLocalDBConnection.Engine
{
	internal static class ExecutionModel
	{
		public static System.Data.DataSet Exec(string CommandText, System.Data.SqlClient.SqlParameter[] values)
        {
            System.Data.DataSet result = new System.Data.DataSet();
            try
            {
                    
                using (SqlConnection dc = new SqlConnection(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
                {
					SqlCommand cmdUn = dc.CreateCommand();
					cmdUn.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;";
                    SqlCommand cmd = dc.CreateCommand();
                    cmd.CommandText = CommandText;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (values.Length != 0)
                    {
                        if (values != null)
                        {
                            foreach (SqlParameter param in values)
                            {
                                if (param.Value == null)
                                {
                                    param.Value = DBNull.Value;
                                }
                                else
                                {
                                    if (param.Value is string)
                                    {
										if (param.Value.GetType().Name=="String")
											param.Value = param.Value.ToString().Replace("'", "''");
                                    }
                                }
                                cmd.Parameters.Add(param);
                            }
                        }
                    }
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = (SqlCommand)cmd;
                    dc.Open();
					cmdUn.ExecuteNonQuery();
                    da.Fill(result);
                    dc.Close();
                    dc.Dispose();
                    da = null;
                    return result;
                }
                    
                
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;


        }
	}
}
