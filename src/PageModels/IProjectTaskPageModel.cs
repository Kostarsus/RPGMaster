using CommunityToolkit.Mvvm.Input;
using RPGMaster.Models;

namespace RPGMaster.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}