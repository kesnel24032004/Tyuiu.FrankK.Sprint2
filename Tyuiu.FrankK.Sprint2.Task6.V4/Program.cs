using Tyuiu.FrankK.Sprint2.Task6.V4.Lib;
namespace Tyuiu.FrankK.Sprint2.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите номер масти: ");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindCardSuit(x);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}