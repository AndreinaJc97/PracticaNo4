﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAgenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewContact : ContentPage
    {
        public NewContact()
        {
            InitializeComponent();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {

        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}