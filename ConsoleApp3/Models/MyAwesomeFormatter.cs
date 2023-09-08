// интерфейсы
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Models
{
    internal class MyAwesomeFormatter : IReportFormatter
    {
        public void Print(IHuman human)
        {
            Console.WriteLine(new string('*', 30));
            Console.WriteLine($"Имя: {human.FirstName}");
            Console.WriteLine($"Отчество: {human.LastName}");
            Console.WriteLine($"Гендер: {human.Gender}");
            Console.WriteLine(new string('*', 30));
        }
    }
}