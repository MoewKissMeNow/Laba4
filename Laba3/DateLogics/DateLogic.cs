namespace Laba3.DateLogics
{
    public class DateLogic 
    {
        public int Day;
        public int Month;
        public int Year;

        public DateLogic(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        
        public bool IsLeapYear()
        {
            if (Year % 400 == 0)
                return true;
            if (Year % 100 == 0)
                return false;
            if (Year % 4 == 0)
                return true;
            
            return false;
        }
        public int ToDays()
        {
            int days = Year * 365 + Day;
            days += (Month - 1) * 30;
            return days;
        }

        public int Difference(DateLogic otherDate)
        {
            int days1 = this.ToDays();
            int days2 = otherDate.ToDays();
            if (days1 > days2)
                return days1 - days2;
            else
                return days2 - days1;
        }
    }
}