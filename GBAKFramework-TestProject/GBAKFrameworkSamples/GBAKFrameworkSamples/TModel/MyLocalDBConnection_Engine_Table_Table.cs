//GBAKFramework open source database processing
using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace GBAK.MyLocalDBConnection.Engine
{
	internal static class Table_Table{
		public static bool UPDATE(GBAK.MyLocalDBConnection.Tables.Table values) {
            using (DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
            {
				object values_name = (values.name == null ? (object)"NULL": values.name);
				object values_surname = (values.surname == null ? (object)"NULL": values.surname);
				object values_age = (values.age == null ? (object)"NULL": values.age);
				object values_female = (values.female == null ? (object)"NULL": values.female);
                
				foreach (GBAK.Engine.ActionWithResultBoolean<GBAK.MyLocalDBConnection.Tables.Table> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.Table>.InsteadTriggerUpdate_Table)
				{
					if(!item(values)) return false;
				}
				
				System.Collections.Generic.IEnumerable<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table> OutputResult = d.ExecuteQuery<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table>("UPDATE [Table] SET [name]=" + (values.name==null?"NULL":"{1}") + ",[surname]=" + (values.surname==null?"NULL":"{2}") + ",[age]=" + (values.age==null?"NULL":"{3}") + ",[female]=" + (values.female==null?"NULL":"{4}") + " OUTPUT INSERTED.Id AS Inserted_Id,DELETED.Id AS Deleted_Id,INSERTED.name AS Inserted_name,DELETED.name AS Deleted_name,INSERTED.surname AS Inserted_surname,DELETED.surname AS Deleted_surname,INSERTED.age AS Inserted_age,DELETED.age AS Deleted_age,INSERTED.female AS Inserted_female,DELETED.female AS Deleted_female where Id={0}", values.Id,values_name,values_surname,values_age,values_female);
				foreach (Action<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table>.TriggerUpdate_Table)
                {
                    item(OutputResult.FirstOrDefault());
                }
            }
            return true;
        }
		public static GBAK.Error Add(out int? Id,GBAK.MyLocalDBConnection.Tables.Table values) {
			GBAK.Error e = new GBAK.Error();
			Id = null;
            using (DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
            {
				if( "name"==GBAK.Engine.HelperMethods.GetVariableName(z=>values.name) & "False"!="True" & values.name==null){
					
					e.Status = true;
					e.SETNotNullable("name");
					throw new System.ArgumentException(e.Description);
					return e;
				}
				object values_name = (values.name == null ? (object)"NULL": values.name);
				if( "surname"==GBAK.Engine.HelperMethods.GetVariableName(z=>values.surname) & "True"!="True" & values.surname==null){
					
					e.Status = true;
					e.SETNotNullable("surname");
					throw new System.ArgumentException(e.Description);
					return e;
				}
				object values_surname = (values.surname == null ? (object)"NULL": values.surname);
				if( "age"==GBAK.Engine.HelperMethods.GetVariableName(z=>values.age) & "True"!="True" & values.age==null){
					
					e.Status = true;
					e.SETNotNullable("age");
					throw new System.ArgumentException(e.Description);
					return e;
				}
				object values_age = (values.age == null ? (object)"NULL": values.age);
				if( "female"==GBAK.Engine.HelperMethods.GetVariableName(z=>values.female) & "True"!="True" & values.female==null){
					
					e.Status = true;
					e.SETNotNullable("female");
					throw new System.ArgumentException(e.Description);
					return e;
				}
				object values_female = (values.female == null ? (object)"NULL": values.female);
				foreach (GBAK.Engine.ActionWithResultBoolean<GBAK.MyLocalDBConnection.Tables.Table> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.Table>.InsteadTriggerInsert_Table)
				{
					if(!item(values)) { e.Status = true;e.Description = "Instead Trigger return false;"; return e; }
				}
					
				System.Collections.Generic.IEnumerable<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table> OutputResult = d.ExecuteQuery<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table>("INSERT INTO [Table] ([name],[surname],[age],[female]) OUTPUT INSERTED.Id AS Inserted_Id,INSERTED.name AS Inserted_name,INSERTED.surname AS Inserted_surname,INSERTED.age AS Inserted_age,INSERTED.female AS Inserted_female VALUES(" + (values.name==null?"NULL":"{0}") + "," + (values.surname==null?"NULL":"{1}") + "," + (values.age==null?"NULL":"{2}") + "," + (values.female==null?"NULL":"{3}") + ");",values_name,values_surname,values_age,values_female);
				var OutputResultData = OutputResult.FirstOrDefault();
				Id = OutputResultData.Inserted_Id;
				foreach (Action<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table>.TriggerInsert_Table)
                {
                    item(OutputResultData);
                }
            }
            return e;
        }
		public static bool DELETE(IQueryable<GBAK.MyLocalDBConnection.Tables.Table> values) {
            using (DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
            {
			   foreach (GBAK.Engine.ActionWithResultBoolean<GBAK.MyLocalDBConnection.Tables.Table> item2 in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.Table>.InsteadTriggerDelete_Table)
				{
					foreach (var item in values)
					{
						if(!item2(item)) return false;
					}
				}
               foreach (var item in values)
                {
					
					
					System.Collections.Generic.IEnumerable<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table> OutputResult = d.ExecuteQuery<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table>("DELETE FROM [Table] OUTPUT DELETED.Id AS Deleted_Id,DELETED.name AS Deleted_name,DELETED.surname AS Deleted_surname,DELETED.age AS Deleted_age,DELETED.female AS Deleted_female WHERE [Id]={0}", item.Id);
					
					foreach (Action<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table> item2 in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_Table>.TriggerDelete_Table)
					{
						item2(OutputResult.FirstOrDefault());
					}
                } 
				
            }
            return true;
        }
	}
}
