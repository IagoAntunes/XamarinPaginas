﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPaginas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinPaginas.TipoPagina.Carousel.TipoPagina1();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
