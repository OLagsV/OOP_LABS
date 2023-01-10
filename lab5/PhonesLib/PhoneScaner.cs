using System.Text;
using System.Text.RegularExpressions;

namespace PhonesLib
{
    public class PhoneScaner
    {
        string inputString;
        public PhoneScaner(string inputString)
        {
            this.inputString = inputString;
        }
        public StringBuilder getShortPhone()
        {
            string searchPhoneShort = @"\D\s\d{3}[\s\-]?\d{2}[\s\-]?\d{2}[\s\.\;]";
            StringBuilder shortPhones = new StringBuilder();
            MatchCollection matches = Regex.Matches(inputString, searchPhoneShort);
            foreach (Match match in matches)
            {
                StringBuilder clearShortPhone = new StringBuilder();
                for(int i = 2; i < match.Value.Length-1; i++)
                {
                    clearShortPhone.Append(match.Value[i]);
                }
                shortPhones.Append(clearShortPhone);
            }
            return shortPhones;
        }
    }
}