using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFDemo2._0.Managers;
using WPFDemo2._0.Models;

namespace WPFDemo2._0.ViewModels;

public class RightViewModel : ObservableObject
{
    private readonly DataModel _dataModel;


    public IRelayCommand CountUpCommand { get; }

    public int Counter
    {
        get { return _dataModel.Counter; }
        set
        {
            SetProperty(_dataModel.Counter, value, _dataModel,
                (model, value) => model.Counter = value);
        }
    }

    public RightViewModel(DataModel dataModel)
    {
        _dataModel = dataModel;
        CountUpCommand = new RelayCommand(() => Counter++);
    }
}