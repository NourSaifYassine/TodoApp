using CommunityToolkit.Mvvm.Input;
using TodoApp.Models;

namespace TodoApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}