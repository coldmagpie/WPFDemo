using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WPFDemo2._0.Managers;

public class NavigationManager
{
    private ObservableObject _currentViewModel;

    public ObservableObject CurrentViewModel
    {
        get { return _currentViewModel; }
        set
        {
            _currentViewModel = value;
            OnCurrentViewModelChanged();
        }
    }

    private void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }

    public event Action CurrentViewModelChanged;
}