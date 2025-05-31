using Xunit;
using System.Collections.Generic;
using TaskManagerApp;

namespace TaskManagerApp.Tests
{
    public class SortStrategyTests
    {
        [Fact]
        public void SortByTitle_ShouldSortAlphabetically()
        {
            var tasks = new List<ITask>
            {
                new RegularTask("Zebra", "desc"),
                new RegularTask("Apple", "desc")
            };

            var sorter = new TaskSorter(new SortByTitle());
            var sorted = sorter.SortTasks(tasks);

            Assert.Equal("Apple", sorted[0].Title);
            Assert.Equal("Zebra", sorted[1].Title);
        }
    }
}
