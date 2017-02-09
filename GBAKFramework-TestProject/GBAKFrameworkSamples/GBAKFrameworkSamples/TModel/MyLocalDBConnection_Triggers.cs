//GBAKFramework open source database processing
using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace GBAK.MyLocalDBConnection
{
	public static class Triggers
	{
		public static void AfterAdd<T>(string Name, GBAK.MyLocalDBConnection.Tables.Name TableName, Action<T> MethodOrDelegate, params TriggerType[] TriggerType)
		{
			if (TableName.ToString() == "Table")
            {
				foreach (TriggerType item in TriggerType)
                {
                    if (item == Triggers.TriggerType.Insert) GBAK.MyLocalDBConnection.Engine.Triggers<T>.TriggerInsert_Table.Add(MethodOrDelegate);
                    if (item == Triggers.TriggerType.Delete) GBAK.MyLocalDBConnection.Engine.Triggers<T>.TriggerDelete_Table.Add(MethodOrDelegate);
                    if (item == Triggers.TriggerType.Update) GBAK.MyLocalDBConnection.Engine.Triggers<T>.TriggerUpdate_Table.Add(MethodOrDelegate);
                }
            }
		}
		public static void InsteadAdd<T>(string Name, GBAK.MyLocalDBConnection.Tables.Name TableName, GBAK.Engine.ActionWithResultBoolean<T> MethodOrDelegate, params TriggerType[] TriggerType)
		{
			if (TableName.ToString() == "Table")
            {
				foreach (TriggerType item in TriggerType)
                {
                    if (item == Triggers.TriggerType.Insert) GBAK.MyLocalDBConnection.Engine.Triggers<T>.InsteadTriggerInsert_Table.Add(MethodOrDelegate);
                    if (item == Triggers.TriggerType.Delete) GBAK.MyLocalDBConnection.Engine.Triggers<T>.InsteadTriggerDelete_Table.Add(MethodOrDelegate);
                    if (item == Triggers.TriggerType.Update) GBAK.MyLocalDBConnection.Engine.Triggers<T>.InsteadTriggerUpdate_Table.Add(MethodOrDelegate);
                }
            }
		}
		public enum TriggerType
		{
			Update,
			Insert,
			Delete
		}
	}
}
