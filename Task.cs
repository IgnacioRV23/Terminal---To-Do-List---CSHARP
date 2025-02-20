namespace app
{
    class Task
    {
        public static List<dynamic> tasks = new List<dynamic>();

        public static void AddTask()
        {
            Console.WriteLine("Task name: ");
            string taskName = Console.ReadLine();

            Console.WriteLine("Task description: ");
            string taskDescription = Console.ReadLine();

            string taskPriority = "";

            while (!new[] { "h", "m", "l" }.Contains(taskPriority.ToLower()))
            {
                Console.WriteLine ("Task priority");
                textArt.ErrorMsg  ("High      [H]");
                textArt.WarningMsg("Medium    [M]");
                textArt.SuccessMsg("Low       [L]");

                taskPriority = Console.ReadLine();
            }

            
            //Method to add new object at list
            tasks.Add(
                new { 
                    id = Guid.NewGuid().ToString(),
                    name = taskName,
                    description = taskDescription,
                    priority = taskPriority
                }
            );

            
        }

        public static void ReadTasks()
        {
            //read task
            foreach (var task in tasks)
            {
                Console.WriteLine(task.id + " name: " + task.name);
            }

            //var tableData = new List<List<object>>
            //{
            //    new List<object>{ "Sakura Yamamoto", "Support Engineer", "London", 46},
            //    new List<object>{ "Serge Baldwin", "Data Coordinator", "San Francisco", 28, "something else" },
            //    new List<object>{ "Shad Decker", "Regional Director", "Edinburgh"},
            //};

            //ConsoleTableBuilder
            //    .From(tableData)
            //    .WithTitle("CONTACTS ", ConsoleColor.White, ConsoleColor.DarkGray)
            //    .WithColumn("Id", "First Name", "Sur Name").ExportAndWriteLine();
        }
    }
}