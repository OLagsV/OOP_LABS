using System;
using System.Collections;

namespace ReaderDiary
{
    public class ReadersDiaryPage
    {
        private string dayName;
        private double detective, thriller, adventure;
        Date date;
        //конструктор класса принимает данные
        public ReadersDiaryPage(int day, int month, int year,string dayName, double detective=0, double thriller=0, double adventure=0)
        {
            this.detective = detective;
            this.thriller = thriller;
            this.adventure = adventure;
            this.dayName = dayName;
            date = new Date(day, month, year);
        }
        

        public double GetDetective()
            { return this.detective; }

        public double GetAdventure()
            { return this.adventure; }
        //метод получения дня или месяца или года в зависимости от слова которое передали в метод
        public int GetDateByString(string param)
        {
            switch(param)
            {
                case "day":
                    return this.date.GetDay();
                case "month":
                    return this.date.GetMonth();
                case "year":
                    return this.date.GetYear();
                default:
                    return -1;
            }
        }

        public double GetThriller()
            { return this.thriller; }

        public string GetDayName()
            { return this.dayName; }
        public string GetDateAsString()
        { return this.date.GetDate(); }
        //получить всю информацию о заметке в виде строки
        public string GetDataInString()
        {
            return $"Приключения: {this.adventure} ч.\n" +
                $"Детективы: {this.detective}\n ч." +
                $"Триллеры: {this.thriller}\n ч." +
                $"Дата прочтения: {this.date.GetDate()}\n" +
                $"День: {this.dayName}";
        }
        //метод получения всех заметок принадлежащих данному врменному интервалу
        public static ReadersDiaryPage[] getFilteredPages(ReadersDiaryPage[] pages,int dayOne, int dayTwo, int monthOne, int monthTwo, int yearOne, int yearTwo)
        {
            ReadersDiaryPage[] filteredPages = new ReadersDiaryPage[pages.Length - 1];
            int checkingPage = 0;
            foreach (ReadersDiaryPage page in pages)
            {
                if (page == null)
                {
                    break;
                }
                int pageDay = page.GetDateByString("day");
                    int pageMonth = page.GetDateByString("month");
                    int pageYear = page.GetDateByString("year");
                    if (pageYear > yearOne && pageYear < yearTwo)
                    {
                        filteredPages[checkingPage] = page;
                    }
                    else if (pageYear == yearOne)
                    {
                        if (pageMonth > monthOne)
                        {
                            filteredPages[checkingPage] = page;
                        }
                        else if (pageMonth == monthOne)
                        {
                            if (pageDay >= dayOne)
                            {
                                filteredPages[checkingPage] = page;
                            }
                        }
                    }
                    else if (pageYear == yearTwo)
                    {
                        if (pageMonth < monthTwo)
                        {
                            filteredPages[checkingPage] = page;
                        }
                        else if (pageMonth == monthTwo)
                        {
                            if (pageDay <= dayTwo)
                            {
                                filteredPages[checkingPage] = page;
                            }
                        }
                    }
                    checkingPage++;
            }
                
            return filteredPages;
        }
    }
}