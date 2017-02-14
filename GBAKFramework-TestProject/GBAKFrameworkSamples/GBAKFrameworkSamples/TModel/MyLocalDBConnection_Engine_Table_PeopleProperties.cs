//GBAKFramework open source database processing
using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace GBAK
{
	public partial class MyLocalDBConnection
	{
		public partial class Engine
		{
			internal static class Table_PeopleProperties
			{
				public static bool UPDATE(GBAK.MyLocalDBConnection.Tables.PeopleProperties values) 
				{
					using (DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
					{
						object values_personID = (values.personID == null ? (object)"NULL": values.personID);
						object values_eyecolor = (values.eyecolor == null ? (object)"NULL": values.eyecolor);
					
						foreach (GBAK.Engine.ActionWithResultBoolean<GBAK.MyLocalDBConnection.Tables.PeopleProperties> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.PeopleProperties>.InsteadTriggerUpdate_PeopleProperties)
						{
							if(!item(values)) return false;
						}
						
						System.Collections.Generic.IEnumerable<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties> OutputResult = d.ExecuteQuery<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties>("UPDATE [PeopleProperties] SET [personID]=" + (values.personID==null?"NULL":"{1}") + ",[eyecolor]=" + (values.eyecolor==null?"NULL":"{2}") + " OUTPUT INSERTED.Id AS Inserted_Id,DELETED.Id AS Deleted_Id,INSERTED.personID AS Inserted_personID,DELETED.personID AS Deleted_personID,INSERTED.eyecolor AS Inserted_eyecolor,DELETED.eyecolor AS Deleted_eyecolor where Id={0}", values.Id,values_personID,values_eyecolor);
						foreach (Action<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties>.TriggerUpdate_PeopleProperties)
						{
							item(OutputResult.FirstOrDefault());
						}
					}
					return true;
				}
				public static GBAK.Error Add(System.Collections.Generic.List<GBAK.MyLocalDBConnection.Tables.PeopleProperties> ListValues) 
				{
			
					GBAK.Error e = new GBAK.Error();
					using (DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
					{
						foreach (var values in ListValues)
						{
							if( "personID"==GBAK.Engine.HelperMethods.GetVariableName(z=>values.personID) & "False"!="True" & values.personID==null){
							
								e.Status = true;
								e.SETNotNullable("personID");
								throw new System.ArgumentException(e.Description);
								return e;
							}
							object values_personID = (values.personID == null ? (object)"NULL": values.personID);
							if( "eyecolor"==GBAK.Engine.HelperMethods.GetVariableName(z=>values.eyecolor) & "True"!="True" & values.eyecolor==null){
							
								e.Status = true;
								e.SETNotNullable("eyecolor");
								throw new System.ArgumentException(e.Description);
								return e;
							}
							object values_eyecolor = (values.eyecolor == null ? (object)"NULL": values.eyecolor);
							foreach (GBAK.Engine.ActionWithResultBoolean<GBAK.MyLocalDBConnection.Tables.PeopleProperties> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.PeopleProperties>.InsteadTriggerInsert_PeopleProperties)
							{
								if(!item(values)) { e.Status = true;e.Description = "Instead Trigger return false;"; return e; }
							}
								
							System.Collections.Generic.IEnumerable<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties> OutputResult = d.ExecuteQuery<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties>("INSERT INTO [PeopleProperties] ([personID],[eyecolor]) OUTPUT INSERTED.Id AS Inserted_Id,INSERTED.personID AS Inserted_personID,INSERTED.eyecolor AS Inserted_eyecolor VALUES(" + (values.personID==null?"NULL":"{0}") + "," + (values.eyecolor==null?"NULL":"{1}") + ");",values_personID,values_eyecolor);
							var OutputResultData = OutputResult.FirstOrDefault();
							foreach (Action<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties>.TriggerInsert_PeopleProperties)
							{
								item(OutputResultData);
							}
						}
					}
					return e;
				
				}
				public static GBAK.Error Add(out int? Id,GBAK.MyLocalDBConnection.Tables.PeopleProperties values) 
				{
					GBAK.Error e = new GBAK.Error();
					Id = null;
					using (DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
					{
						if( "personID"==GBAK.Engine.HelperMethods.GetVariableName(z=>values.personID) & "False"!="True" & values.personID==null){
							
							e.Status = true;
							e.SETNotNullable("personID");
							throw new System.ArgumentException(e.Description);
							return e;
						}
						object values_personID = (values.personID == null ? (object)"NULL": values.personID);
						if( "eyecolor"==GBAK.Engine.HelperMethods.GetVariableName(z=>values.eyecolor) & "True"!="True" & values.eyecolor==null){
							
							e.Status = true;
							e.SETNotNullable("eyecolor");
							throw new System.ArgumentException(e.Description);
							return e;
						}
						object values_eyecolor = (values.eyecolor == null ? (object)"NULL": values.eyecolor);
						foreach (GBAK.Engine.ActionWithResultBoolean<GBAK.MyLocalDBConnection.Tables.PeopleProperties> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.PeopleProperties>.InsteadTriggerInsert_PeopleProperties)
						{
							if(!item(values)) { e.Status = true;e.Description = "Instead Trigger return false;"; return e; }
						}
							
						System.Collections.Generic.IEnumerable<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties> OutputResult = d.ExecuteQuery<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties>("INSERT INTO [PeopleProperties] ([personID],[eyecolor]) OUTPUT INSERTED.Id AS Inserted_Id,INSERTED.personID AS Inserted_personID,INSERTED.eyecolor AS Inserted_eyecolor VALUES(" + (values.personID==null?"NULL":"{0}") + "," + (values.eyecolor==null?"NULL":"{1}") + ");",values_personID,values_eyecolor);
						var OutputResultData = OutputResult.FirstOrDefault();
						Id = OutputResultData.Inserted_Id;
						foreach (Action<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties> item in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties>.TriggerInsert_PeopleProperties)
						{
							item(OutputResultData);
						}
					}
					return e;
				}
				public static bool DELETE(IQueryable<GBAK.MyLocalDBConnection.Tables.PeopleProperties> values) {
					using (DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
					{
					   foreach (GBAK.Engine.ActionWithResultBoolean<GBAK.MyLocalDBConnection.Tables.PeopleProperties> item2 in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.PeopleProperties>.InsteadTriggerDelete_PeopleProperties)
						{
							foreach (var item in values)
							{
								if(!item2(item)) return false;
							}
						}
					   foreach (var item in values)
						{
							
							
							System.Collections.Generic.IEnumerable<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties> OutputResult = d.ExecuteQuery<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties>("DELETE FROM [PeopleProperties] OUTPUT DELETED.Id AS Deleted_Id,DELETED.personID AS Deleted_personID,DELETED.eyecolor AS Deleted_eyecolor WHERE [Id]={0}", item.Id);
							
							foreach (Action<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties> item2 in GBAK.MyLocalDBConnection.Engine.Triggers<GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_PeopleProperties>.TriggerDelete_PeopleProperties)
							{
								item2(OutputResult.FirstOrDefault());
							}
						} 
					}
					return true;
				}
			}
		}
	}
}
