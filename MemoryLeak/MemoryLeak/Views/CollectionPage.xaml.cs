using MemoryLeak.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemoryLeak.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionPage : ContentPage
    {
        public CollectionPage()
        {
            InitializeComponent();
            BindingContext = new CollectionViewModel();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ((CollectionViewModel)BindingContext).Posts.Clear();
            ((CollectionViewModel)BindingContext).Posts = null;
            BindingContext = null;
            CollectionPageView = null;
        }
    }
}