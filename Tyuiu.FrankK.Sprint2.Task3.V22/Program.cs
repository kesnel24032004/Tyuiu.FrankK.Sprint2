using Tyuiu.FrankK.Sprint2.Task3.V22.Lib;
namespace Tyuiu.FrankK.Sprint2.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите Х: ");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}