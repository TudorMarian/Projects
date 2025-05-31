using System.Collections.Generic;
using System.Linq;

namespace TaskManagerApp
{
    public class SortByPriority : ISortStrategy
    {
        public List<ITask> Sort(List<ITask> tasks)
        {
            return tasks.OrderBy(t => t.Priority).ToList();
        }
    }
}
