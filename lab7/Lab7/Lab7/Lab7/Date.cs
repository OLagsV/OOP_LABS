using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Date
    {
        private int day, month, year;
        public Date(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int GetDay()
        {
            return day;
        }
        public int GetMonth()
        {
            return month;
        }
        public int GetYear()
        {
            return year;
        }
        public string GetDateAsString()
        {
            return $"{this.day}.{this.month}.{this.year}";
        }
    }
}
