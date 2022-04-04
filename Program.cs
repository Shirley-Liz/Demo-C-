using System;
using Tourism.Services;
using Tourism.ToViewLater;

namespace Tourism
{
    class Program
    {
        static void Main(string[] args)
        {
            var toDoService = new GenericService<ToDo>();
            var groupService = new GenericService<Group>();

            var shopping = new ToDo
            {
                Name = "Love",
                Body = "Shop all the Kitchen groceries",
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow,
            };

            toDoService.Add(shopping);
            Console.WriteLine(shopping);
            groupService.Add(new Group
            {
                Name = "Teacher",
                ToDo = "Shopping",
                Department = "Science",
                Users = "shirley"
            }) ;

            //Creating and initialising a data dictionary
            //var repo = new Repository();
            //repo.ArrayDictionary.Add("gdf", new List<string> { "", "", "" });

            //Adding items to a data repo
            //repo.Add("Tuza", "Lions");
            //repo.Add("Racheal", "Crested Cranes");
            //repo.Add("Mercy", "Zebras");
            //repo.Add("Lucy", "Giraffes");
            //repo.Add("Brian", "Hippopotamus");
            //repo.Add("Robert", "Hippopotamus");
            //repo.Add("Moureen", "Hippopotamus");

            //looping through the dictionary and retrieving the items in it
            //foreach (var item in repo.GetDictionary())
            //{
            //Console.WriteLine(item.Key + " " + item.Value);
            //}

            //foreach (var item in repo.ArrayDictionary)
            //{
            //Console.WriteLine(item.Key);
            //foreach (var value in item.Value)
            //{
            //Console.WriteLine(value);
            //}
            //}

            // retriving a Value of a key
            //Console.WriteLine(repo.GetDictionary()["Tuza"]);
            //if (repo.GetDictionary().ContainsKey("Racheal"))
            // {
            // repo.GetDictionary().Remove("Racheal");
            //foreach (var item in repo.GetDictionary())
            //{
            //Console.WriteLine(item.Key + " " + item.Value);
            //}
            //}
            //adding more elements to the key Mercy in the data dictionary / Updating
            // repo.GetDictionary()["Mercy"] = "antelopes, squirrels";
            // Using for statement to retrieve the key values pairs of the data in the dictionary
            //foreach (var item in repo.GetDictionary())
            //{
            //Console.WriteLine(item.Key + " " + item.Value);

            //}
            // IEnumerable<object> namesOfCompanies = from name in repo.GetDictionary()
            //where(name.Value == "Hippopotamus")
            //select new
            //{
            //name.Key,
            //name.Value
            //};

            //var newList = repo.GetDictionary().Where(x => x.Value == "Hippopotamus")
            // .Select(x => x.Key);


            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (var item in newList)
            //{
            //Console.WriteLine(item);
            //}

            //var array = new string[] { };

            //var tt = array.Select(x => x[..1]);

            // Console.ReadKey();
             }
            }
        }
