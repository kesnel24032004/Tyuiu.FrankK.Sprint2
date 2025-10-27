using Tyuiu.FrankK.Sprint2.Task5.V5.Lib;
namespace Tyuiu.FrankK.Sprint2.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите номер карты: ");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindCardValue(x);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}