﻿using UpCarteira.Views;

namespace UpCarteira
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
