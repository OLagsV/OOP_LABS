using ReaderDiary;
using System.Media;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsApp
{
    public partial class ReaderDiary : System.Windows.Forms.Form
    {

        ReadersDiaryPage[] pages = new ReadersDiaryPage[32];
        int currentPage = 0;
        public ReaderDiary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //кнопка записи введеной информации
        private void button1_Click(object sender, EventArgs e)
        {
            double detective, thriller, adventure;
            int year, day, month;
            //получение чисел из текстовых полей если поле пустое то записываетс€ 0 по умолчанию
            detective = Convert.ToDouble(textBox1.Text == "" ? "0" : textBox1.Text);
            adventure = Convert.ToDouble(textBox2.Text == "" ? "0" : textBox2.Text);
            thriller = Convert.ToDouble(textBox3.Text == "" ? "0" : textBox3.Text);
            day = Convert.ToInt32(textBox5.Text);
            month = Convert.ToInt32(textBox6.Text);
            year = Convert.ToInt32(textBox7.Text);
            string dayName = textBox13.Text;
            //формирование самого объекта ReaderDiaryPage и занесение его в массив всех записей
            pages[currentPage] = new ReadersDiaryPage(day, month, year, dayName, detective, thriller, adventure);
            LastCheck.Text = "ѕоследн€€ запись:\n" + pages[currentPage].GetDataInString();
            checksComboBox.Items.Clear();
            foreach (var page in pages)
            {
                if(page == null)
                {
                    break;
                }
                checksComboBox.Items.Add(page.GetDateAsString());
            }
            currentPage++;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //вывод информации записи по дате
        private void checksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = checksComboBox.SelectedIndex;
            choosenCheckLabel.Text = pages[checksComboBox.SelectedIndex].GetDataInString();
            textBox1.Text = Convert.ToString(pages[id].GetDetective());
            textBox2.Text = Convert.ToString(pages[id].GetAdventure());
            textBox3.Text = Convert.ToString(pages[id].GetThriller());
            textBox5.Text = Convert.ToString(pages[id].GetDateByString("day"));
            textBox6.Text = Convert.ToString(pages[id].GetDateByString("month"));
            textBox7.Text = Convert.ToString(pages[id].GetDateByString("year"));
        }
        //редактирование записи полученной по дате
        private void button2_Click(object sender, EventArgs e)
        {
            int detective, thriller, adventure;
            int year, day, month;
            detective = Convert.ToInt32(textBox1.Text == "" ? "0" : textBox1.Text);
            adventure = Convert.ToInt32(textBox2.Text == "" ? "0" : textBox2.Text);
            thriller = Convert.ToInt32(textBox3.Text == "" ? "0" : textBox3.Text);
            day = Convert.ToInt32(textBox5.Text);
            month = Convert.ToInt32(textBox6.Text);
            year = Convert.ToInt32(textBox7.Text);
            string dayName = textBox13.Text;
            pages[checksComboBox.SelectedIndex] = new ReadersDiaryPage(day, month, year,dayName, detective, thriller, adventure);
            checksComboBox.Items.Clear();
            foreach (var page in pages)
            {
                if (page == null)
                {
                    break;
                }
                checksComboBox.Items.Add(page.GetDateAsString());
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstYearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReaderDiary_Load(object sender, EventArgs e)
        {

        }
        //подсчет среднего времени чтени€ за заданный период
        private void periodAmountBtn_Click(object sender, EventArgs e)
        {
            //получение периода за который нужно посчитать
            int dayOne = Convert.ToInt32(textBox4.Text);
            int dayTwo = Convert.ToInt32(textBox10.Text);
            int monthOne = Convert.ToInt32(textBox8.Text);
            int monthTwo = Convert.ToInt32(textBox11.Text);
            int yearOne = Convert.ToInt32(textBox9.Text);
            int yearTwo = Convert.ToInt32(textBox12.Text);
            double allHours = 0;
            //получение записей за данный период
            ReadersDiaryPage[] filteredPages = ReadersDiaryPage.getFilteredPages(pages,dayOne,dayTwo,monthOne,monthTwo,yearOne,yearTwo);
            foreach (ReadersDiaryPage page in filteredPages)
            {
                if (page == null)
                {
                    break;
                }
                allHours = allHours + page.GetDetective() + page.GetThriller() + page.GetAdventure();

            }
            double avgHours = Math.Round((allHours / currentPage),2);
            label12.Text = avgHours.ToString();
        }
        //поиск самого попул€рного жанра за период
        private void popularExercPeriodBtn_Click(object sender, EventArgs e)
        {
            int dayOne = Convert.ToInt32(textBox14.Text);
            int dayTwo = Convert.ToInt32(textBox17.Text);
            int monthOne = Convert.ToInt32(textBox15.Text);
            int monthTwo = Convert.ToInt32(textBox18.Text);
            int yearOne = Convert.ToInt32(textBox16.Text);
            int yearTwo = Convert.ToInt32(textBox19.Text);
            double detective = 0;
            double thriller = 0;
            double adventure = 0;
            ReadersDiaryPage[] filteredPages = ReadersDiaryPage.getFilteredPages(pages, dayOne, dayTwo, monthOne, monthTwo, yearOne, yearTwo);
            //подсчет часов по каждому жанру
            foreach (ReadersDiaryPage page in filteredPages)
            {
                if (page == null)
                {
                    break;
                }
                detective += page.GetDetective();
                    thriller += page.GetThriller();
                    adventure += page.GetAdventure();
            }
            double maxHour = Math.Max(detective, Math.Max(thriller, adventure));
            string maxGenre = "";
            //определение попул€рного жанра
            if(maxHour == detective)
            {
                maxGenre = $"ƒетективы - {detective} ч.";
            } else if (maxHour == thriller)
            {
                maxGenre = $"“риллеры - {thriller} ч.";
            }
            else if (maxHour == adventure)
            {
                maxGenre = $"ѕриключени€ - {adventure} ч.";
            }
            label13.Text = maxGenre;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        // поиск дн€ с мин времен чтени€
        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            double minHour = pages[0].GetDetective() + pages[0].GetThriller() + pages[0].GetAdventure();
            string minDayName = pages[0].GetDayName();
            foreach (ReadersDiaryPage page in pages)
            {
                if (page == null)
                {
                    break;
                }
                double currentHours=page.GetDetective() + page.GetThriller() + page.GetAdventure();
                    if(currentHours < minHour)
                    {
                        minHour = currentHours;
                        minDayName = page.GetDayName();
                    }
                i++;
            }
            label14.Text = minDayName;
        }
    }
}