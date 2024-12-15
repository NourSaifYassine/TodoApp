using TodoApp.Models;

namespace TodoApp.Pages.Controls
{
    public partial class TaskView : ContentView
    {
        public TaskView()
        {
            InitializeComponent();
        }

        private void OnAddSubTaskButtonClicked(object sender, EventArgs e)
        {
            if (BindingContext is Models.Task task)
            {
                var newSubTask = new SubTask { Title = "Nieuwe Subtaak", IsCompleted = false };
                task.SubTasks.Add(newSubTask);
                // Dit zorgt ervoor dat de UI wordt bijgewerkt
                SubTasksCollectionView.ItemsSource = null;
                SubTasksCollectionView.ItemsSource = task.SubTasks;
            }
        }
    }
}
