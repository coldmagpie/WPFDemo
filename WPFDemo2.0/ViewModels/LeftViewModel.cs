using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFDemo2._0.Managers;
using WPFDemo2._0.Models;

namespace WPFDemo2._0.ViewModels;

public class LeftViewModel : ObservableObject
{
    private readonly DataModel _dataModel;
    // IRelayCommand implementeras av ICommand
    public IRelayCommand CountDownCommand { get; }

	public int Counter
	{
		get { return _dataModel.Counter; }
        set
        {
            SetProperty( _dataModel.Counter, value, _dataModel, 
                (model,value)=>model.Counter=value);
        }
	}

    public LeftViewModel(DataModel dataModel)
    {
        _dataModel = dataModel;
        CountDownCommand = new RelayCommand(() => Counter--);
    }
}