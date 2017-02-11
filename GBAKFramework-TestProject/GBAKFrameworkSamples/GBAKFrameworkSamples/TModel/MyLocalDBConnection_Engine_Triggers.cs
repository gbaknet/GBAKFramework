//GBAKFramework open source database processing
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
namespace GBAK.MyLocalDBConnection.Engine
{
	internal static class Triggers<T>
	{
		public static List<Action<T>> TriggerInsert_People { get; set; } = new List<Action<T>>() { };
		public static List<Action<T>> TriggerUpdate_People { get; set; } = new List<Action<T>>() { };
		public static List<Action<T>> TriggerDelete_People { get; set; } = new List<Action<T>>() { };
		public static List<GBAK.Engine.ActionWithResultBoolean<T>> InsteadTriggerInsert_People { get; set; } = new List<GBAK.Engine.ActionWithResultBoolean<T>>() { };
		public static List<GBAK.Engine.ActionWithResultBoolean<T>> InsteadTriggerUpdate_People { get; set; } = new List<GBAK.Engine.ActionWithResultBoolean<T>>() { };
		public static List<GBAK.Engine.ActionWithResultBoolean<T>> InsteadTriggerDelete_People { get; set; } = new List<GBAK.Engine.ActionWithResultBoolean<T>>() { };
		public static List<Action<T>> TriggerInsert_PeopleProperties { get; set; } = new List<Action<T>>() { };
		public static List<Action<T>> TriggerUpdate_PeopleProperties { get; set; } = new List<Action<T>>() { };
		public static List<Action<T>> TriggerDelete_PeopleProperties { get; set; } = new List<Action<T>>() { };
		public static List<GBAK.Engine.ActionWithResultBoolean<T>> InsteadTriggerInsert_PeopleProperties { get; set; } = new List<GBAK.Engine.ActionWithResultBoolean<T>>() { };
		public static List<GBAK.Engine.ActionWithResultBoolean<T>> InsteadTriggerUpdate_PeopleProperties { get; set; } = new List<GBAK.Engine.ActionWithResultBoolean<T>>() { };
		public static List<GBAK.Engine.ActionWithResultBoolean<T>> InsteadTriggerDelete_PeopleProperties { get; set; } = new List<GBAK.Engine.ActionWithResultBoolean<T>>() { };
	}
}

