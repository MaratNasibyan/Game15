using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Game15.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public MainWindowViewModel()
        {

        }

        private async Task InitializeAsync()
        {           
            await LoadData(4);
        }

        public async Task LoadData(int size)
        {
            //var data = await _movieService.GetMovies(page);
            //await Task.Delay(1000);
            //MyItems = new ObservableCollection<Movie>(data);
        }
    }
}
