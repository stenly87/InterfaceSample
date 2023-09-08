// интерфейсы
using ConsoleApp3.Interfaces;
using ConsoleApp3.Models;
using ConsoleApp3.Shitfunc;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main()
        {
            ReportModule reportModule = new ReportModule();
            List<IHuman> humans = new List<IHuman>();
            humans.Add(new Student { FirstName = "Вася", LastName = "Петрович", Gender = Gender.Мужской });
            humans.Add(new Prepod { FirstName = "Алина", LastName = "Алисовна", Gender = Gender.Женский });

            reportModule.PrintsomeReport(humans, new MyShitFormatter());
        }
    }
}
