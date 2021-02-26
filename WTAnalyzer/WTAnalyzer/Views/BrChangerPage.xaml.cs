﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTAnalyzer.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WTAnalyzer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrChangerPage : ContentPage
    {
        public BrChangerPage()
        {
            InitializeComponent();
            BindingContext = new BrChangerViewModel();
        }
    }
}