using ConsoleTableExt;

namespace app
{ 
    class Program
    {
        static void Main()
        {
            Console.Title = "Console 🔥";

            textArt.Welcome();


            var tableData = new List<List<object>>
{
                new List<object>{ "Sakura Yamamoto", "Support Engineer", "London", 46},
                new List<object>{ "Serge Baldwin", "Data Coordinator", "San Francisco", 28, "something else" },
                new List<object>{ "Shad Decker", "Regional Director", "Edinburgh"},
};

            ConsoleTableBuilder
                .From(tableData)
                .WithTitle("CONTACTS ", ConsoleColor.White, ConsoleColor.DarkGray)
                .WithColumn("Id", "First Name", "Sur Name").ExportAndWriteLine();


            Console.ReadKey();
        }

        public static void SuccessMsg(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
