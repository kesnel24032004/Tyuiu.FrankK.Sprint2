using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FrankK.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
            if (x > 1)
                return Math.Round(x + Math.Pow(((x + 3) / (x - 1)), x),3);
            else if (x == 0)
                return Math.Round((Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12),3);
            else if ((x > (-26)) & (x < 2))
                return Math.Round(Math.Pow((3 + (2 / Math.Pow(x, 2))), x), 3);
            else 
                return Math.Round((x + (10 * x) - (1 / x)), 3);
        }
    }
}
