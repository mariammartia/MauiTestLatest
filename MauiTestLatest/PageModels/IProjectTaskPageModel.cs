using CommunityToolkit.Mvvm.Input;
using MauiTestLatest.Models;

namespace MauiTestLatest.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}