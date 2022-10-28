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
            ((CollectionViewModel)BindingContext).Posts1.Clear();
            ((CollectionViewModel)BindingContext).Posts1 = null;
            ((CollectionViewModel)BindingContext).Posts2.Clear();
            ((CollectionViewModel)BindingContext).Posts2 = null;

            Collection1 = null;
            Collection2 = null;
            Collection3 = null;

            BindingContext = null;
            CollectionPageView = null;
        }
    }
}