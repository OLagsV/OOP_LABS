using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab7
{
    //Абстрактный класс Fish
    public abstract class Fish
    {
        public string Kind { get; set; }
        public int Amount { get; set; }
        public Date Date { get; set; }
        public string EatingType { get; set; }

        public Fish(string kind, int amount, int day, int month, int year)
        {
            Kind = kind;
            Amount = amount;
            Date = new Date(day, month, year);
        }
        public int GetAmount()
        {
            return Amount;
        }
        public string ShowInfo()
        {
            return $" Вид - {Kind}; Объем улова - {Amount}; Питание - {EatingType}; Дата улова - {Date.GetDateAsString()}\n";
        }
    }
    public class Predatory : Fish
    {
        public Predatory(string kind, int amount, int day, int month, int year) : base(kind, amount,day,month,year)
        {
            EatingType = "хищная";
        }
    }
    public class Herbivorous : Fish
    {
        public Herbivorous(string kind, int amount, int day, int month, int year) : base(kind, amount, day, month, year)
        {
            EatingType = "травоядная";
        }
    }
    public class Omnivorous : Fish
    {
        public Omnivorous(string kind, int amount, int day, int month, int year) : base(kind, amount, day, month, year)
        {
            EatingType = "всеядная";

        }
    }
    public class Bottom : Fish
    {
        public Bottom(string kind, int amount, int day, int month, int year) : base(kind, amount, day, month, year)
        {
            EatingType = "донная";

        }
    }

    //основаня программа
    public class MainClass
    {
        //список уловов
        private List<Fish> Fish = new List<Fish>();
        //метод добавления новой рыбы в список уловов
        //принимает всю информацию о рыбе и в зависимости от переданного типа питания создает определенную рыбу
        public void AddFish(string kind, int amount, string eatingType, int day,int month,int year)
        {
            switch (eatingType)
            {
                case "Хищная":
                    Fish.Add(new Predatory(kind, amount,day,month,year));
                    break;
                case "Травоядная":
                    Fish.Add(new Herbivorous(kind, amount, day, month, year));
                    break;
                case "Всеядная":
                    Fish.Add(new Omnivorous(kind, amount, day, month, year));
                    break;
                case "Донная":
                    Fish.Add(new Bottom(kind, amount, day, month, year));
                    break;
            }
        }
        //получить средние уловы по типу питания
        public string GetAwerageAmountByEatingType()
        {
            string result = " ";
            List<string> fishes = new List<string>();
            for (int i = 0; i < Fish.Count; i++)
            {
                if (!fishes.Contains(Fish[i].EatingType))
                {
                    fishes.Add(Fish[i].EatingType);
                }
            }
            for (int i = 0; i < fishes.Count; i++)
            {
                double amountByFish = 0;
                int col = 0;
                for (int j = 0; j < Fish.Count; j++)
                {
                    if (fishes[i] == Fish[j].EatingType)
                    {
                        col++;
                        amountByFish += Fish[j].GetAmount();
                    }
                }
                result += $"{fishes[i]} - {amountByFish / col}\n";
            }
            return result;
        }
        //получить средние уловы по видам
        public string GetAwerageAmountByKind()
        {
            string result = " ";
            List<string> fishes = new List<string>();
            for (int i = 0; i < Fish.Count; i++)
            {
                if (!fishes.Contains(Fish[i].Kind))
                {
                    fishes.Add(Fish[i].Kind);
                }
            }
            for (int i = 0; i < fishes.Count; i++)
            {
                double amountByFish = 0;
                int col = 0;
                for (int j = 0; j < Fish.Count; j++)
                {
                    if (fishes[i] == Fish[j].Kind)
                    {
                        col++;
                        amountByFish += Fish[j].GetAmount();
                    }
                }
                result += $"{fishes[i]} - {amountByFish / col}\n";
            }
            return result;
        }
        //узнать тип питания с максимальным уловом
        public string GetBiggestType()
        {
            string result = " ";
            int maxAmount = 0;
            List<string> fishes = new List<string>();
            for (int i = 0; i < Fish.Count; i++)
            {
                if (!fishes.Contains(Fish[i].EatingType))
                {
                    fishes.Add(Fish[i].EatingType);
                }
            }
            for (int i = 0; i < fishes.Count; i++)
            {
                int amountByFish = 0;
                int col = 0;
                for (int j = 0; j < Fish.Count; j++)
                {
                    if (fishes[i] == Fish[j].EatingType)
                    {
                        col++;
                        amountByFish += Fish[j].GetAmount();
                    }
                }
                if (amountByFish > maxAmount)
                {
                    maxAmount = amountByFish;
                    result = $"{fishes[i]} - {amountByFish / col}\n";
                }
                
            }
            return result;
        }

    }
}


