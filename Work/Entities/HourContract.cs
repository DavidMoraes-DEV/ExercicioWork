using System;
using System.Collections.Generic;
using System.Text;

namespace Work.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract (DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double totalValue (double valuePerHour, int hours)
        {
            return valuePerHour * hours;
        }
    }
}
