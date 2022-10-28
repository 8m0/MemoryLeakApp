using MemoryLeak.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MemoryLeak.ViewModels
{
    public class CollectionViewModel : BaseViewModel
    {
        public ObservableCollection<Post> Posts { get; set; }
        public ObservableCollection<Post> Posts1 { get; set; }
        public ObservableCollection<Post> Posts2 { get; set; }

        public ICommand GoBackCommand { get; }

        public CollectionViewModel()
        {
            GoBackCommand = new Command(async () => await Shell.Current.GoToAsync("../"));
            GetMockData();
        }

        private void GetMockData()
        {
            List<Post> posts = new List<Post>();

            for (int i = 0; i < 100000; i++)
            {
                posts.Add(new Post
                {
                    Id = i,
                    UserId = i,
                    Title = "eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati",
                    Body = "eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati"
                });
            }
            Posts = new ObservableCollection<Post>(posts);
            posts.Clear();
            for (int i = 0; i < 100000; i++)
            {
                posts.Add(new Post
                {
                    Id = i,
                    UserId = i,
                    Title = "eum et est occaecati eum et estww ww ww occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati",
                    Body = "eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati"
                });
            }
            Posts1 = new ObservableCollection<Post>(posts);
            posts.Clear();
            for (int i = 0; i < 100000; i++)
            {
                posts.Add(new Post
                {
                    Id = i,
                    UserId = i,
                    Title = "eum et est occaecati eum et est ee eee ee occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati",
                    Body = "eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati eum et est occaecati"
                });
            }
            Posts2 = new ObservableCollection<Post>(posts);
        }
    }
}
