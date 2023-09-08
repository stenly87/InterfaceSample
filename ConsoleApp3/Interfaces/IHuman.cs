// интерфейсы

using ConsoleApp3.Shitfunc;

namespace ConsoleApp3.Interfaces
{
    public interface IHuman
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Gender Gender { get; set; }
    }


}
