using Xunit;
using TaskManagerApp;

namespace TaskManagerApp.Tests
{
    public class TaskFactoryTests
    {
        [Fact]
        public void CreateTask_ShouldReturnImportantTask_WhenTypeIsImportant()
        {
            var task = TaskFactory.CreateTask("important", "TestTitle", "TestDesc");
            Assert.IsType<ImportantTask>(task);
        }

        [Fact]
        public void CreateTask_ShouldReturnRegularTask_WhenTypeIsRegular()
        {
            var task = TaskFactory.CreateTask("regular", "TestTitle", "TestDesc");
            Assert.IsType<RegularTask>(task);
        }
    }
}
