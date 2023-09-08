// интерфейсы
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Models
{
    internal class MyShitFormatter : IReportFormatter
    {
        public void Print(IHuman human)
        {
            Console.Write(human.LastName + " ");
        }
    }
}