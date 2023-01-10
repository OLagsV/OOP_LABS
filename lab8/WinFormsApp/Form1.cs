using PolygobClasses;
using System.Transactions;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        Polygon[] polygons = new Polygon[20];
        int curArrLen;
        public Form1()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("polygons.txt"))
            {
                int i = 0;
                string? line;
                int[] numbers;
                line = reader.ReadLine();
                while (line != null)
                {
                   string[] coords = line.Split(' ');
                    switch (coords.Length)
                    {
                        case 7: 
                            numbers = CreateNumArr(6, coords, 1);
                            polygons[i] = new Triangle(numbers, Color.FromName(coords[0]));
                            break;
                        case 9:
                            numbers = CreateNumArr(8, coords, 1);
                            polygons[i] = new PolygobClasses.Rectangle(numbers, Color.FromName(coords[0]));
                            break;
                    }
                    i++;
                    line = reader.ReadLine();
                }
                curArrLen = i;
            }
        }

        static int[] CreateNumArr(int len, string[] strArr, int shift)
        {
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (int.TryParse(strArr[i+shift], out arr[i]))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            return arr;
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            int curStrLen = 0;
            richTextBox.Text = "";
            while (polygons[i] != null) //цикл для добавления текста в текстбокс
            {

                richTextBox.Text += $"{polygons[i].GetObjectInfo()}\n";
                i++;
            }
            for(i = 0; i<curArrLen; i++) //цикл для раскраски текста
            {
                
                richTextBox.SelectionStart = curStrLen;
                richTextBox.SelectionLength = curStrLen + polygons[i].GetObjectInfo().Length+1;
                //+1 потому что в строке находится еще \n 
                richTextBox.SelectionColor = polygons[i].color;
                curStrLen += polygons[i].GetObjectInfo().Length+1;
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            Array.Sort(polygons, 0, curArrLen);
            
            int i = 0;
            richTextBox.Text = "";
            while (i < curArrLen)
            {
                richTextBox.Text += $"{polygons[i].GetObjectInfo()}\n";
                i++;
            }
        }

        private void quartBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            richTextBox.Text = "";
            while (i < curArrLen)
            {
                if(polygons[i].IsBelongsToOneQuarter()) richTextBox.Text += $"{polygons[i].GetObjectInfo()}\n";
                i++;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string[] coords = coordsLabel.Text.Split(' ');
            int[] numbers;
            switch (coords.Length)
            {
                case 6:
                    numbers = CreateNumArr(6, coords, 0);
                    polygons[curArrLen] = new Triangle(numbers, Color.FromName(colorLabel.Text));
                    break;
                case 8:
                    numbers = CreateNumArr(8, coords, 0);
                    polygons[curArrLen] = new PolygobClasses.Rectangle(numbers, Color.FromName(colorLabel.Text));
                    break;
            }
            if(polygons[curArrLen] != null) curArrLen++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}