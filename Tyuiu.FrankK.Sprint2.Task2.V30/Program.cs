using Tyuiu.FrankK.Sprint2.Task2.V30.Lib;
namespace Tyuiu.FrankK.Sprint2.Task2.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x;
            int y;
            Console.WriteLine("Введите x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = int.Parse(Console.ReadLine());
            bool res;
            res = ds.CheckDotInShadedArea(x, y);
            if (res == true)
                Console.WriteLine("Попадает");
            else
                Console.WriteLine("Не попадает");
            Console.ReadKey();
        }
    }
}