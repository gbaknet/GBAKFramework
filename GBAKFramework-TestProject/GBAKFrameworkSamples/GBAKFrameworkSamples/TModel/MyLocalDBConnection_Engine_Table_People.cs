//GBAKFramework open source database processing
using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace GBAK.MyLocalDBConnection.Engine
{
	internal static class Table_People{
		public static bool UPDATE(GBAK.MyLocalDBConnection.Tables.People values) {
            using (DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
            {
				object values_name = (values.name == null ? (object)"NULL": values.name);
				object values_surname = (values.surname == null ? (object)"NULL": values.surname);
				object values_age = (values.age == null ? (object)"NULL": values.age);
				object values_female = (values.female == null ? (object)"NULL": values.female);
                
				foreach (GBAK.Engine.ActionWithResultBoolean<GBAK.MyLocalDBConnection.Tables.People> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.People>.InsteadTriggerUpdate_People)
				{
					if(!item(values)) return false;
				}
				
				System.Collections.Generic.IEnumerable<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People> OutputResult = d.ExecuteQuery<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People>("UPDATE [People] SET [name]=" + (values.name==null?"NULL":"{1}") + ",[surname]=" + (values.surname==null?"NULL":"{2}") + ",[age]=" + (values.age==null?"NULL":"{3}") + ",[female]=" + (values.female==null?"NULL":"{4}") + " OUTPUT INSERTED.Id AS Inserted_Id,DELETED.Id AS Deleted_Id,INSERTED.name AS Inserted_name,DELETED.name AS Deleted_name,INSERTED.surname AS Inserted_surname,DELETED.surname AS Deleted_surname,INSERTED.age AS Inserted_age,DELETED.age AS Deleted_age,INSERTED.female AS Inserted_female,DELETED.female AS Deleted_female where Id={0}", values.Id,values_name,values_surname,values_age,values_female);
				foreach (Action<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People>.TriggerUpdate_People)
                {
                    item(OutputResult.FirstOrDefault());
                }
            }
            return true;
        }
		public static GBAK.Error Add(out int? Id,GBAK.MyLocalDBConnection.Tables.People values) {
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
				foreach (GBAK.Engine.ActionWithResultBoolean<GBAK.MyLocalDBConnection.Tables.People> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.People>.InsteadTriggerInsert_People)
				{
					if(!item(values)) { e.Status = true;e.Description = "Instead Trigger return false;"; return e; }
				}
					
				System.Collections.Generic.IEnumerable<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People> OutputResult = d.ExecuteQuery<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People>("INSERT INTO [People] ([name],[surname],[age],[female]) OUTPUT INSERTED.Id AS Inserted_Id,INSERTED.name AS Inserted_name,INSERTED.surname AS Inserted_surname,INSERTED.age AS Inserted_age,INSERTED.female AS Inserted_female VALUES(" + (values.name==null?"NULL":"{0}") + "," + (values.surname==null?"NULL":"{1}") + "," + (values.age==null?"NULL":"{2}") + "," + (values.female==null?"NULL":"{3}") + ");",values_name,values_surname,values_age,values_female);
				var OutputResultData = OutputResult.FirstOrDefault();
				Id = OutputResultData.Inserted_Id;
				foreach (Action<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People>.TriggerInsert_People)
                {
                    item(OutputResultData);
                }
            }
            return e;
        }
		public static bool DELETE(IQueryable<GBAK.MyLocalDBConnection.Tables.People> values) {
            using (DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
            {
			   foreach (GBAK.Engine.ActionWithResultBoolean<GBAK.MyLocalDBConnection.Tables.People> item2 in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.People>.InsteadTriggerDelete_People)
				{
					foreach (var item in values)
					{
						if(!item2(item)) return false;
					}
				}
               foreach (var item in values)
                {
					
					
					System.Collections.Generic.IEnumerable<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People> OutputResult = d.ExecuteQuery<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People>("DELETE FROM [People] OUTPUT DELETED.Id AS Deleted_Id,DELETED.name AS Deleted_name,DELETED.surname AS Deleted_surname,DELETED.age AS Deleted_age,DELETED.female AS Deleted_female WHERE [Id]={0}", item.Id);
					
					foreach (Action<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People> item2 in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People>.TriggerDelete_People)
					{
						item2(OutputResult.FirstOrDefault());
					}
                } 
				
            }
            return true;
        }
	}
}
