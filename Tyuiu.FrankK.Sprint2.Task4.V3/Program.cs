using Tyuiu.FrankK.Sprint2.Task4.V3.Lib;
namespace Tyuiu.FrankK.Sprint2.Task4.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите Х: ");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            double y;
            y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}