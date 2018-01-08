using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ValidationEntrySample.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.LoginViewModel();
        }
    }
}
