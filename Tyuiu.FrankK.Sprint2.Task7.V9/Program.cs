using Tyuiu.FrankK.Sprint2.Task7.V9.Lib;
namespace Tyuiu.FrankK.Sprint2.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите X: ");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            double y;
            y = Convert.ToDouble(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}