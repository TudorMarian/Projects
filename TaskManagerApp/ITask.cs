namespace TaskManagerApp
{
    public interface ITask
    {
        string Title { get; }
        string Description { get; }
        int Priority { get; } // 1 = High, 2 = Medium, 3 = Low

        void DisplayInfo();
    }
}
