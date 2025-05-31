using System.Collections.Generic;

namespace TaskManagerApp
{
    public interface ISortStrategy
    {
        List<ITask> Sort(List<ITask> tasks);
    }
}
