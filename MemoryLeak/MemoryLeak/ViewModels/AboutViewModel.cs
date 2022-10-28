using MemoryLeak.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MemoryLeak.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private static int count = 0;
        private static int gcCount = 0;

        private string _buttonText;
        public string ButtonText
        {
            get => _buttonText;
            set
            {
                SetProperty(ref _buttonText, value);
            }
        }

        private string _tryToGcText;
        public string TryToGcText
        {
            get => _tryToGcText;
            set
            {
                SetProperty(ref _tryToGcText, value);
            }
        }

        public AboutViewModel()
        {
            TryToGcText = "Try to GC.Collect()";
            ButtonText = "Go to page with collection";
            Title = "Xamarin forms RAM memory leak";
            OpenWebCommand = new Command(async () =>
            {
                count++;
                ButtonText = $"Go to page with collection ({count})";
                await Shell.Current.GoToAsync(nameof(CollectionPage));
            });
            GcCollectCommand = new Command(() =>
            {
                gcCount++;
                TryToGcText = $"Try to GC.Collect ({gcCount})";
                GC.Collect();
            });
        }

        public ICommand OpenWebCommand { get; }
        public ICommand GcCollectCommand { get; }
    }
}