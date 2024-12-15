namespace TodoApp.Models
{
    public class SubTask
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }

    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public List<SubTask> SubTasks { get; set; } = new List<SubTask>(); // Voeg lijst van subtaken toe
    }
}
