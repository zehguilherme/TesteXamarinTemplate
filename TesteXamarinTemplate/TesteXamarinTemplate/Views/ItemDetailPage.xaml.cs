using System.ComponentModel;
using TesteXamarinTemplate.ViewModels;
using Xamarin.Forms;

namespace TesteXamarinTemplate.Views
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