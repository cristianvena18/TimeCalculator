using System;
using System.Collections.Generic;
using System.Text;

namespace TimeCalculator.Models
{
    public enum MenuItemType
    {
        HourCalculator,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
