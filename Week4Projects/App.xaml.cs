using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week4Projects
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TableViewPage();
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
