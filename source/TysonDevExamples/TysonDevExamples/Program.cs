using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Components.DictionaryAdapter;

namespace TysonDevExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dict = new Dictionary<string, object>()
                {
                    { "USER_FName", "Tim" },
                    { "USER_LName", "Rayburn" }
                };

                var da = new DictionaryAdapterFactory().GetAdapter<IPerson>(dict);
                Console.WriteLine(da.FirstName);
                Console.WriteLine(da.LastName);

                da.Aliases = new List<string>() { "Doug", "DaBomb", "Plushy" };

                Console.WriteLine(dict["USER_Aliases"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Complete!");
            Console.ReadLine();
        }
    }

    [KeyPrefix("USER_")]
    public interface IPerson
    {
        [Key("FName")]
        string FirstName { get; set; }
        [Key("LName")]
        string LastName { get; set; }
        [StringList(Separator='|')]
        List<string> Aliases { get; set; }
    }
}
