﻿using PayeTonEnchère.Vues;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace PayeTonEnchère
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MonInscriptionPage();
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