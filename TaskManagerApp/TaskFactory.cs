namespace TaskManagerApp
{
    public static class TaskFactory
    {
        public static ITask CreateTask(string type, string title, string description)
        {
            switch (type.ToLower())
            {
                case "important":
                    return new ImportantTask(title, description);
                case "regular":
                    return new RegularTask(title, description);
                default:
                    throw new ArgumentException("Unknown task type");
            }
        }
    }
}
