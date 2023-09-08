// интерфейсы
using ConsoleApp3.Interfaces;
using ConsoleApp3.Shitfunc;

namespace ConsoleApp3.Models
{
    internal class Student : IHuman
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
    }


}
