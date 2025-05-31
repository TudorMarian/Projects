using System.Collections.Generic;

namespace TaskManagerApp
{
    public class TaskSorter
    {
        private ISortStrategy _sortStrategy;

        public TaskSorter(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SetStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public List<ITask> SortTasks(List<ITask> tasks)
        {
            return _sortStrategy.Sort(tasks);
        }
    }
}
