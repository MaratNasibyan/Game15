using Avalonia.Threading;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Game15.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {      
        private int timer = default;
        private TimeSpan timeSpan;

        public TimeSpan TimeSpan
        {
            get => timeSpan;
            set => this.RaiseAndSetIfChanged(ref timeSpan, value);
        }


        public MainWindowViewModel()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        public void dispatcherTimer_Tick(object? sender, EventArgs e)
        {
            TimeSpan = TimeSpan.FromSeconds(timer++);
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
