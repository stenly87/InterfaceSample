// интерфейсы
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Models
{
    public class ReportModule
    {
        public void PrintsomeReport(List<IHuman> humans, IReportFormatter reportFormatter)
        {
            foreach (IHuman human in humans)
            {
                reportFormatter.Print(human);
            }
        }
    }


}
