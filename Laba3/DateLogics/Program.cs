namespace Laba3.DateLogics
{
    namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                DateLogic date1 = new DateLogic(10, 3, 2024);
                DateLogic date2 = new DateLogic(15, 4, 2023);

                Console.WriteLine("Дата 1 високосний рік: " + date1.IsLeapYear());
                Console.WriteLine("Дата 2 високосний рік: " + date2.IsLeapYear());

                int difference = date1.Difference(date2);
                Console.WriteLine("Різниця між датами (в днях): " + difference);

                Console.ReadLine();
            }
        }
    }
}