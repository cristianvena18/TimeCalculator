using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeCalculator.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeCalculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HourCalculator : ContentPage
    {
        private HourCalculatorViewModel viewModel;

        public HourCalculator()
        {
            InitializeComponent();
            BindingContext = this.viewModel = new HourCalculatorViewModel();
        }

        private void OnDateSelected(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}