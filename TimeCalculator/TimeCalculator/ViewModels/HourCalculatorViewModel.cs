using System;
using System.Collections.Generic;
using System.Text;

namespace TimeCalculator.ViewModels
{
    public class HourCalculatorViewModel : BaseViewModel
    {
        public TimeSpan today { get; private set; }
        public TimeSpan tomorrow { get; private set; }
        public HourCalculatorViewModel()
        {
            this.today = new TimeSpan();
            this.tomorrow = new TimeSpan();
        }
    }
}
