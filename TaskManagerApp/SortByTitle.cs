using System.Collections.Generic;
using System.Linq;

namespace TaskManagerApp
{
    public class SortByTitle : ISortStrategy
    {
        public List<ITask> Sort(List<ITask> tasks)
        {
            return tasks.OrderBy(t => t.Title).ToList();
        }
    }
}
