//GBAKFramework open source database processing
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
namespace GBAK.MyLocalDBConnection.Engine
{
	internal static class Triggers<T>
	{
		public static List<Action<T>> TriggerInsert_Table { get; set; } = new List<Action<T>>() { };
		public static List<Action<T>> TriggerUpdate_Table { get; set; } = new List<Action<T>>() { };
		public static List<Action<T>> TriggerDelete_Table { get; set; } = new List<Action<T>>() { };
		public static List<GBAK.Engine.ActionWithResultBoolean<T>> InsteadTriggerInsert_Table { get; set; } = new List<GBAK.Engine.ActionWithResultBoolean<T>>() { };
		public static List<GBAK.Engine.ActionWithResultBoolean<T>> InsteadTriggerUpdate_Table { get; set; } = new List<GBAK.Engine.ActionWithResultBoolean<T>>() { };
		public static List<GBAK.Engine.ActionWithResultBoolean<T>> InsteadTriggerDelete_Table { get; set; } = new List<GBAK.Engine.ActionWithResultBoolean<T>>() { };
	}
}

