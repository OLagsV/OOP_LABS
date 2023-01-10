using DeepEqual.Syntax;
using ReaderDiary;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFilterPage()
        {
            ReadersDiaryPage[] pages = new ReadersDiaryPage[5];
            pages[0] = new ReadersDiaryPage(1, 1, 2000, "Понедельник", 4.2, 1.2, 0.8);
            pages[1] = new ReadersDiaryPage(2, 6, 2000, "Вторник", 0, 0, 0);
            pages[2] = new ReadersDiaryPage(5, 12, 2001, "Суббота", 6.3, 2.2, 0.1);
            pages[3] = new ReadersDiaryPage(11, 8, 2001, "Пятница", 4, 3, 1.9);
            int[] days = { 1, 10 };
            int[] month = { 1, 12 };
            int[] years = { 1999, 2002 };
            ReadersDiaryPage expected = new ReadersDiaryPage(1, 1, 2000, "Понедельник", 4.2, 1.2, 0.8);
            ReadersDiaryPage actual = ReadersDiaryPage.getFilteredPages(pages, 1, 10, 1, 12, 1999, 2002)[0];
            Console.Write(Convert.ToString(actual.GetThriller()));
            Assert.AreEqual(true,expected.IsDeepEqual(ReadersDiaryPage.getFilteredPages(pages, days[0], days[1], month[0], month[1], years[0], years[1])[0]));
        }

    }
}