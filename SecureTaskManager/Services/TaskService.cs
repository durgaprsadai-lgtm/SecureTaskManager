using SecureTaskManager.Models;

namespace SecureTaskManager.Services
{
    public class TaskService
    {
        private readonly List<TaskItem> _tasks = new();
        private int _idCounter = 1;

        public IEnumerable<TaskItem> GetAll() => _tasks;

        public TaskItem Add(string description)
        {
            var task = new TaskItem { Id = _idCounter++, Description = description };
            _tasks.Add(task);
            return task;
        }
    }
}
