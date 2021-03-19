using Avalonia.Threading;
using Game15.Services;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace Game15.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {  
    
        public MainWindowViewModel()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
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
       

        public void StartNewGame()
        {
            dispatcherTimer.Start();
            counter = 0;
        }        

        #region Timer

        TimeSpan timer;
        int counter = default;
        DispatcherTimer dispatcherTimer;

        public TimeSpan Timer
        {
            get => timer;
            set => this.RaiseAndSetIfChanged(ref timer, value);
        } 

        public void DispatcherTimer_Tick(object? sender, EventArgs e)
        {
            Timer = TimeSpan.FromSeconds(counter++);
        }

        #endregion Timer
    }
}
