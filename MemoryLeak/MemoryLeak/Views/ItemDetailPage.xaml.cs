using MemoryLeak.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MemoryLeak.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}