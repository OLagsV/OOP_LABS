namespace customArrsLib
{
    public class OdnomerMass
    {
        //приватное поле содержащее сам массив
        private double[] array = { };
        //поле имени
        public string arrName = "";
        //конструктор класса принимает массив вещ цисел и строку с именем
        public OdnomerMass(double[] arr,string name)
        {
            this.array = arr;
            this.arrName = name;
        }
        //конструктор без параметров
        public OdnomerMass()
        {
        }
        //метод позволяющий получить поле содержащее сам массив
        public double[] getArr()
        {
            return this.array;
        }
        //метод позволяющий получить длину содержащегося массив
        public int getLength()
        {
            return array.Length;
        }
        //получить элемент массива по номеру(индексу)
        public double getAnEllement(int index)
        {
            return array[index];
        }
        //метод для вывода массива
        public void printArr()
        {
            Console.WriteLine(string.Join(" ", this.array));
        }
        //метод для поэлементного ввода массива
        public void enterArr()
        {
            string name = Console.ReadLine();
            int arrSize = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Array[{i}] = ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            this.array = arr;
            this.arrName = name;
        }
        //метод умножающий определенные элементы (номера элементов содеражться в массиве indexes) или если массив не передавали в функцию то просто суммирует все элементы
        public double summOrUmnozh(params int[] indexes)
        {
            if(indexes.Length == 0)
            {
                double summ = 0;
                for(int i = 0; i < this.array.Length; i++)
                {
                    summ += this.array[i];
                }
                return summ;
            } else
            {
                double proizv = 1;
                for (int i = 0; i < indexes.Length; i++)
                {
                    proizv *= this.array[indexes[i]];
                }
                return proizv;
            }
            
        }
        //метод выводящий  всю информацию о массиве(имя сам массив и длину)
        static public string convertToString(OdnomerMass toConvert)
        {
            return "Имя: " + toConvert.arrName + " \n" + "Размер " + toConvert.getLength() + "\n" + "Массива: " + string.Join(" ", toConvert.array);
        }
        //метод деления двух массивов если они одинаковой длины
        static public double[] delenie(double[] arr1, double[] arr2)
        {
            if(arr1.Length == arr2.Length)
            {
                double[] resultArr = new double[arr1.Length];
                for(int i = 0; i< arr1.Length; i++)
                {
                    resultArr[i] = arr1[i] / arr2[i];
                }
                return resultArr;
            }
            else
            {
                return null;
            }
        }
    }
}