namespace TaskManagerApp
{
    public class ImportantTask : ITask
    {
        public string Title { get; }
        public string Description { get; }
        public int Priority => 1;

        public ImportantTask(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"[Important] {Title} - {Description} (Priority: {Priority})");
        }
    }
}
