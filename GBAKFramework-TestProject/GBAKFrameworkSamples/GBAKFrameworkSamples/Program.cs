using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBAKFrameworkSamples
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {


                using (var SELECT = new GBAK.MyLocalDBConnection.Tables.SELECT())
                {
                    if (SELECT.Table().Count() == 0)
                    {
                        Random r = new Random();

                        GBAK.MyLocalDBConnection.Tables.Add(new GBAK.MyLocalDBConnection.Tables.Table() { age = (byte)r.Next(18, 60), female = (r.Next(0, 2) == 1 ? false : true), name = "Lorem", surname = "Ipsum" });
                    }



                }

                using (var SELECT = new GBAK.MyLocalDBConnection.Tables.SELECT())
                {
                    var tbl = SELECT.Table();
                    foreach (var item in tbl)
                    {
                        Console.WriteLine(string.Format("ID: {0} - Name: {1} - Surname: {2} - Age: {3} - Sex: {4}", item.Id, item.name, item.surname, item.age, ((bool)item.female ? "Female" : "Male")));
                    }
                    Console.Write("Would you like to delete this recording? (yes/no):> ");
                    if (Console.ReadLine() == "yes")
                    {
                        tbl.Remove();
                    }
                }

                using (var EXEC = new GBAK.MyLocalDBConnection.SP.EXEC())
                {
                    Console.Write("Write Record ID:> ");
                    string id = Console.ReadLine();
                    int id_ = 0;
                    if (!int.TryParse(id, out id_)) id_ = 0;
                    var sp = EXEC.get_table(id_);
                    var Rsl1 = sp.Result1.FirstOrDefault();
                    if (Rsl1 != null)
                    {
                        Console.WriteLine(string.Format("ID: {0} - Name: {1} - Surname: {2} - Age: {3} - Sex: {4}", Rsl1.Id, Rsl1.name, Rsl1.surname, Rsl1.age, ((bool)Rsl1.female ? "Female" : "Male")));
                    }
                    else
                    {
                        Console.WriteLine("Record not found.");
                    }
                }
                Console.WriteLine("Click to continue.");
                Console.ReadLine();
            }
        }
    }
}
