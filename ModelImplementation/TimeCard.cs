using System;
using System.Collections.Generic;
using System.Text;

namespace ModelImplementation
{
    public class TimeCard
    {
        private readonly DateTime itsDate;
        private double itsHours;

        public TimeCard(DateTime date, double hours)
        {
            itsDate = date;
            itsHours = hours;
        }

        public DateTime GetDate()
        {
            return itsDate;
        }

        public double GetHours()
        {
            return itsHours;
        }
    }
}
