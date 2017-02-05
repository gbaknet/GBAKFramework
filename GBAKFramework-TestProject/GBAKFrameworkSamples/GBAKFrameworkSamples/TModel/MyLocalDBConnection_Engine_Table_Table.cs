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
                
				d.ExecuteCommand("UPDATE [Table] SET [name]=" + (values.name==null?"NULL":"{1}") + ",[surname]=" + (values.surname==null?"NULL":"{2}") + ",[age]=" + (values.age==null?"NULL":"{3}") + ",[female]=" + (values.female==null?"NULL":"{4}") + " where Id={0}", values.Id,values_name,values_surname,values_age,values_female);
            }
            return true;
        }
		public static GBAK.Error Add(GBAK.MyLocalDBConnection.Tables.Table values) {
			GBAK.Error e = new GBAK.Error();
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
                d.ExecuteCommand("INSERT INTO [Table] ([name],[surname],[age],[female])VALUES(" + (values.name==null?"NULL":"{0}") + "," + (values.surname==null?"NULL":"{1}") + "," + (values.age==null?"NULL":"{2}") + "," + (values.female==null?"NULL":"{3}") + ");",values_name,values_surname,values_age,values_female);
            }
            return e;
        }
		public static bool DELETE(IQueryable<GBAK.MyLocalDBConnection.Tables.Table> values) {
            using (DataContext d = new DataContext(GBAK.Engine.PublicVariable.Connection_MyLocalDBConnection))
            {
               foreach (var item in values)
                {
                    d.ExecuteCommand("DELETE FROM [Table] WHERE [Id]={0}", item.Id);
                } 
				
            }
            return true;
        }
	}
}
