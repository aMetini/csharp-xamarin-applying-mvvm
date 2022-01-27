using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    // To implement INotifyPropertyChanged you need to declare the PropertyChanged event and create the OnPropertyChanged method.  Then for each property that you want to change
    // notifications for, you call OnPropertyChanged whenever the property is updated.  The handler for PropertyChanged is added to the XAML file
    public class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Private field _title
        private string _title = "Roster App";

        //public string Title { get; set; } = "Roster App";

        // Property title will get private field _title and set _title to a value. The PropertyChanged is called to set(i.e. update) the property Title.  
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                PropertyChanged(_title, new PropertyChangedEventArgs(nameof(Title)));
            }
        }
        public Command UpdateApplicationCommand { get; }

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(UpdateApplicationCommandExecute);
        }

        // Private method UpdateApplicationCommandExecute
        // Allows for any change made in the ViewModel (i.e.Title) to be updated to the View
        private void UpdateApplicationCommandExecute()
        {
            Title = "Roster App (v2.0)";

        }
    }
}
