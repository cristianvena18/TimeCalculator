using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TimeCalculator.Services;
using TimeCalculator.Views;

namespace TimeCalculator
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<CalculatorService>();
            MainPage = new MainPage();
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
