//GBAKFramework open source database processing
using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace GBAK
{
	public partial class MyLocalDBConnection
	{
		public static class Triggers
		{
			public static void AfterAdd<T>(string Name, GBAK.MyLocalDBConnection.Tables.Name TableName, Action<T> MethodOrDelegate, params TriggerType[] TriggerType)
			{
				if (TableName.ToString() == "People")
				{
					foreach (TriggerType item in TriggerType)
					{
						if (item == Triggers.TriggerType.Insert) GBAK.MyLocalDBConnection.Engine.Triggers<T>.TriggerInsert_People.Add(MethodOrDelegate);
						if (item == Triggers.TriggerType.Delete) GBAK.MyLocalDBConnection.Engine.Triggers<T>.TriggerDelete_People.Add(MethodOrDelegate);
						if (item == Triggers.TriggerType.Update) GBAK.MyLocalDBConnection.Engine.Triggers<T>.TriggerUpdate_People.Add(MethodOrDelegate);
					}
				}
				if (TableName.ToString() == "PeopleProperties")
				{
					foreach (TriggerType item in TriggerType)
					{
						if (item == Triggers.TriggerType.Insert) GBAK.MyLocalDBConnection.Engine.Triggers<T>.TriggerInsert_PeopleProperties.Add(MethodOrDelegate);
						if (item == Triggers.TriggerType.Delete) GBAK.MyLocalDBConnection.Engine.Triggers<T>.TriggerDelete_PeopleProperties.Add(MethodOrDelegate);
						if (item == Triggers.TriggerType.Update) GBAK.MyLocalDBConnection.Engine.Triggers<T>.TriggerUpdate_PeopleProperties.Add(MethodOrDelegate);
					}
				}
			}
			public static void InsteadAdd<T>(string Name, GBAK.MyLocalDBConnection.Tables.Name TableName, GBAK.Engine.ActionWithResultBoolean<T> MethodOrDelegate, params TriggerType[] TriggerType)
			{
				if (TableName.ToString() == "People")
				{
					foreach (TriggerType item in TriggerType)
					{
						if (item == Triggers.TriggerType.Insert) GBAK.MyLocalDBConnection.Engine.Triggers<T>.InsteadTriggerInsert_People.Add(MethodOrDelegate);
						if (item == Triggers.TriggerType.Delete) GBAK.MyLocalDBConnection.Engine.Triggers<T>.InsteadTriggerDelete_People.Add(MethodOrDelegate);
						if (item == Triggers.TriggerType.Update) GBAK.MyLocalDBConnection.Engine.Triggers<T>.InsteadTriggerUpdate_People.Add(MethodOrDelegate);
					}
				}
				if (TableName.ToString() == "PeopleProperties")
				{
					foreach (TriggerType item in TriggerType)
					{
						if (item == Triggers.TriggerType.Insert) GBAK.MyLocalDBConnection.Engine.Triggers<T>.InsteadTriggerInsert_PeopleProperties.Add(MethodOrDelegate);
						if (item == Triggers.TriggerType.Delete) GBAK.MyLocalDBConnection.Engine.Triggers<T>.InsteadTriggerDelete_PeopleProperties.Add(MethodOrDelegate);
						if (item == Triggers.TriggerType.Update) GBAK.MyLocalDBConnection.Engine.Triggers<T>.InsteadTriggerUpdate_PeopleProperties.Add(MethodOrDelegate);
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
}
