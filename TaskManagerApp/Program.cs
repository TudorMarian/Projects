using System;
using System.Collections.Generic;

namespace TaskManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ITask> tasks = new List<ITask>
            {
                TaskFactory.CreateTask("important", "Meeting with CEO", "Prepare quarterly report"),
                TaskFactory.CreateTask("regular", "Reply emails", "Respond to client messages"),
                TaskFactory.CreateTask("important", "Team Review", "Give feedback to developers"),
                TaskFactory.CreateTask("regular", "Clean desk", "Organize workspace")
            };

            Console.WriteLine("Choose sorting strategy:");
            Console.WriteLine("1. Sort by Priority");
            Console.WriteLine("2. Sort by Title");
            Console.Write("Your choice: ");
            var input = Console.ReadLine();

            ISortStrategy strategy = input == "1"
                ? new SortByPriority()
                : new SortByTitle();

            var sorter = new TaskSorter(strategy);
            var sortedTasks = sorter.SortTasks(tasks);

            Console.WriteLine("\nSorted Tasks:");
            foreach (var task in sortedTasks)
            {
                task.DisplayInfo();
            }

            Console.ReadLine();
        }
    }
}
