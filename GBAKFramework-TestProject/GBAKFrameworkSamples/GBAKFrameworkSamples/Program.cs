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

            GBAK.MyLocalDBConnection.Triggers.AfterAdd("Name1", GBAK.MyLocalDBConnection.Tables.Name.People, delegate (GBAK.MyLocalDBConnection.Tables.TableAfterTrigger_People tbl) { Console.WriteLine("After Trigger> ID {4} - Name: {0} - Surname: {1} - Age: {2} - Female: {3}", tbl.Inserted_name,tbl.Inserted_surname, tbl.Inserted_age, tbl.Inserted_female, tbl.Inserted_Id); }, GBAK.MyLocalDBConnection.Triggers.TriggerType.Insert);


            GBAK.MyLocalDBConnection.Triggers.InsteadAdd("Name2", GBAK.MyLocalDBConnection.Tables.Name.People, delegate (GBAK.MyLocalDBConnection.Tables.People tbl) { Console.WriteLine("Instead Trigger> ID {4} - Name: {0} - Surname: {1} - Age: {2} - Female: {3}", tbl.name, tbl.surname, tbl.age, tbl.female, tbl.Id); return true; }, GBAK.MyLocalDBConnection.Triggers.TriggerType.Insert);

            while (true)
            {


                using (var SELECT = new GBAK.MyLocalDBConnection.Tables.SELECT())
                {
                    if (SELECT.People().Count() == 0)
                    {
                        Random r = new Random();

                        GBAK.MyLocalDBConnection.Tables.Add(new GBAK.MyLocalDBConnection.Tables.People() { age = (byte)r.Next(18, 60), female = (r.Next(0, 2) == 1 ? false : true), name = "Lorem", surname = "Ipsum" });
                    }



                }


                
                using (var SELECT = new GBAK.MyLocalDBConnection.Tables.SELECT())
                {
                    var tbl = SELECT.People();
                    foreach (var item in tbl)
                    {
                        Console.WriteLine(string.Format("FE> ID: {0} - Name: {1} - Surname: {2} - Age: {3} - Sex: {4}", item.Id, item.name, item.surname, item.age, ((bool)item.female ? "Female" : "Male")));
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
