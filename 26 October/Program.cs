//using System;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography.X509Certificates;
//using Newtonsoft.Json;

//namespace _26_October
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Daxil etmek istediyiniz adi daxil edin:");
//            string NameThatWeWantToAdd = Console.ReadLine();
//            Add(NameThatWeWantToAdd);

//            Console.WriteLine("Axtarmaq istediyiniz adi daxil edin:");
//            string SearchedName = Console.ReadLine();
//            bool SearchResult = Search(SearchedName, (name) => name == SearchedName);
//            Console.WriteLine($"Search result: {SearchResult}");

//            Console.WriteLine("Silmek istetiyiniz adi daxil edin:");
//            string NameThatWeWantToDelete = Console.ReadLine();
//            Delete(NameThatWeWantToDelete);


//        }

//        public static string path = "name.json";

//        private static void WriteToDb(List<string> names)
//        {

//            string data = JsonConvert.SerializeObject(names);
//            using (StreamWriter sw = new(path))
//            {
//                sw.Write(data);
//            }


//        }
//        private static List<string> ReadFromDb()
//        {
            
//            List<string> result;
//            if (!File.Exists(path)) 
//                File.Create(path).Close();
//            using (StreamReader sr = new(path))
//            {
//                result = JsonConvert.DeserializeObject<List<string>>(sr.ReadToEnd());
//            }
//            if (result is null) result = new();
//            return result;
            

//        }
//        public static void Add(string name)
//        {
//            List<string>names= ReadFromDb();
            
//            names.Add(name);
//            WriteToDb(names);
            
//        }
//        public static void Delete(string name)
//        {
//            List<string>names = ReadFromDb();
//            names.Remove(name);
//            WriteToDb(names);
//        }
        
//            public static bool Search(string name, Predicate<string> match)
//        {
//            List<string> names = ReadFromDb();
//            return names.Exists(match);
//        }
//    }
//}
