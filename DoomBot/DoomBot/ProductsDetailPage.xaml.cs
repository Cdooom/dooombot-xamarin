﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DoomBot
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsDetailPage : ContentPage
    {
        public ProductsDetailPage(Models.User products)
        {
            if (products == null)
                throw new ArgumentException();

            BindingContext = products;
            InitializeComponent();
        }
    }
}