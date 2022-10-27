using System.Security.Permissions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFDemo2._0.Managers;

namespace WPFDemo2._0.ViewModels;

public class MainViewModel : ObservableObject
{
    private readonly NavigationManager _navigationManager;
    private readonly DataManager _dataManager;

    public IRelayCommand NavigateLeftCommand { get; }

    public IRelayCommand NavigateRightCommand { get; }

    public ObservableObject CurrentViewModel
    {
        get => _navigationManager.CurrentViewModel;
    }

    public MainViewModel(NavigationManager navigationManager, DataManager dataManager)
    {
        _navigationManager = navigationManager;
        _dataManager = dataManager;

        NavigateLeftCommand = new RelayCommand(() => _navigationManager.CurrentViewModel = new LeftViewModel(_dataManager.DataModel));
        NavigateRightCommand = new RelayCommand(() => _navigationManager.CurrentViewModel = new RightViewModel(_dataManager.DataModel));

        _navigationManager.CurrentViewModelChanged += CurrentViewModelChanged;
    }

    private void CurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}