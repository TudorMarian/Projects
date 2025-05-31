namespace TaskManagerApp
{
    public class RegularTask : ITask
    {
        public string Title { get; }
        public string Description { get; }
        public int Priority => 3;

        public RegularTask(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"[Regular] {Title} - {Description} (Priority: {Priority})");
        }
    }
}
