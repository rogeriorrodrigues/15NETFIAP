using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Layouts15NET.Views;

namespace XF.Layouts15NET
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPageXF();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
