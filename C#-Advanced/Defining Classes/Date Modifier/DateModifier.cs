using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    class DateModifier
    {
        public int GetDayDifference(string startDateString,string endDateString)
        {
            DateTime startDate = DateTime.Parse(startDateString);
            DateTime endDate = DateTime.Parse(endDateString);
            int result = (int)(endDate - startDate).TotalDays;
            return result;
        }
    }
}
