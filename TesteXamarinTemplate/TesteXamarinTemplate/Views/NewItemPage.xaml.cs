using System;
using System.Collections.Generic;
using System.ComponentModel;
using TesteXamarinTemplate.Models;
using TesteXamarinTemplate.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteXamarinTemplate.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}