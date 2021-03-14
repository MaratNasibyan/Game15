using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace Game15.Views
{
    public class MainWindow : Window
    {
        Game game;
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            game = new Game(4);
            game.Start();
            Refresh();
        }


        private void OnButtonClick(object sender, RoutedEventArgs e)
        {       
            var name = ((Button)sender).Name?.ToString();
            Button button = this.FindControl<Button>(name);
            game.Shift(int.Parse(name));
            Refresh();
            //button.Content = button.Name;
        }

      
        private void Refresh()
        {
            for (int i = 0; i < 16; i++)
            {

                Button button = this.FindControl<Button>(i.ToString());

                button.Content = game.GetNumber(i).ToString();
                button.IsVisible = game.GetNumber(i) > 0;
            }
        }
    }
}
