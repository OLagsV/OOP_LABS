using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderDiary
{
    internal class Date
    {
        private int day, month, year;
        internal Date(int day, int month, int year)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public string GetDate()
        {
            return $"{day}.{month}.{year}";
        }
        public int GetYear()
        {
            return year;
        }

        public int GetMonth()
        {
            return month;
        }

        public int GetDay()
        {
            return day;
        }
    }
}
