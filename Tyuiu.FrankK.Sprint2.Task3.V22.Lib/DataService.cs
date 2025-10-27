using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FrankK.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
            if (x > 1)
                return x + Math.Pow(((x + 3) / (x - 1)), x);
            else if (x == 0)
                return (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
            else if ((x > (-26)) & (x < 2))
                return Math.Pow((3 + (2 / Math.Pow(x, 2))), x);
            else 
                return (x + (10 * x) - (1 / x));
        }
    }
}
