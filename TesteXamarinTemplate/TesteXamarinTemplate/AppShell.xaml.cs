using System;
using System.Collections.Generic;
using TesteXamarinTemplate.ViewModels;
using TesteXamarinTemplate.Views;
using Xamarin.Forms;

namespace TesteXamarinTemplate
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
