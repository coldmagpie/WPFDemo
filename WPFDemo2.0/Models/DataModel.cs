using System;

namespace WPFDemo2._0.Models;

public class DataModel
{
	private int _counter;

	public int Counter
	{
		get { return _counter; }
        set
        {
            _counter = value;
            CounterChanged?.Invoke(this, EventArgs.Empty);
        }
	}

    public event EventHandler<EventArgs> CounterChanged;
}