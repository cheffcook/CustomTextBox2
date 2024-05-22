using System.Collections.ObjectModel;
using System.Windows;
using Prism.Commands;
using Prism.Mvvm;

namespace ListViewSample
{
    public class ParameterItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }

        public ParameterItem(int id, string name, double value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
    }

    public class MainViewModel : BindableBase
    {
        int idx = 0;
        double vle = 123.45d;

        public ObservableCollection<ParameterItem> ParametersList { get; set; }

        private ParameterItem _selectedItem;
        public ParameterItem SelectedItem
        {
            get => _selectedItem;
            set
            { 
                SetProperty(ref _selectedItem, value, nameof(SelectedItem));
            }
        }

        public DelegateCommand PushButton { get; }
        public DelegateCommand PushButtonPnl { get; set; }

        public MainViewModel() 
        {
            ParametersList = new();

            PushButton = new DelegateCommand(() => 
            {
                Something();
            });

            Something();

            PushButtonPnl = new DelegateCommand(() =>
            {
                var txt = _selectedItem == null ? "NULL" : _selectedItem.Value.ToString();
                MessageBox.Show(txt);
            });
        }

        private void Something()
        {
            ParametersList.Add(new ParameterItem(idx++, $"Par{idx}", vle * idx));
        }
    }
}
