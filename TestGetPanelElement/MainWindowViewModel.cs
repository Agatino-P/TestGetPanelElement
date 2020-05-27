using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TestGetPanelElement
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Person> _people = new ObservableCollection<Person>(); 
        public ObservableCollection<Person> People { get => _people; set { Set(() => People, ref _people, value); }}

        public MainWindowViewModel()
        {
            loadSampleData();
        }

        private void loadSampleData()
        {
            People.Add(new Person("uno", 1));
            People.Add(new Person("due", 2));
            People.Add(new Person("tre", 3));
        }
    }
}
