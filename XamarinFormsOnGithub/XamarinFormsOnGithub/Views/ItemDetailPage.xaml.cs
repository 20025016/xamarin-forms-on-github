﻿using System.ComponentModel;
using Xamarin.Forms;
using XamarinFormsOnGithub.ViewModels;

namespace XamarinFormsOnGithub.Views
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