using System;
using System.Collections.Generic;
using System.Text;

namespace TimeCalculator.Interfaces
{
    public interface ICalculatorService
    {
        TimeSpan CalculateHours(TimeSpan init, TimeSpan end);
        DateTime CalculateDays(DateTime init, DateTime end);
    }
}
