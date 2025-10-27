using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FrankK.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int value)
        {
            string c = "";
            switch(value)
            {
                case 6:
                    c = "шестерка";
                    break;
                case 7:
                    c = "семерка";
                    break;
                case 8:
                    c = "восьмерка";
                    break;
                case 9:
                    c = "девятка";
                    break;
                case 10:
                    c = "десятка";
                    break;
                case 11:
                    c = "валет";
                    break;
                case 12:
                    c = "дама";
                    break;
                case 13:
                    c = "король";
                    break;
                case 14:
                    c = "туз";
                    break;



            }
            return c;
        }
    }
}
