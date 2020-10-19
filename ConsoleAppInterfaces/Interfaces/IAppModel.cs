using ConsoleAppInterfaces.Models;

namespace ConsoleAppInterfaces
{
    public interface IAppModel
    {
        string Name { get; }
        int Size { get; }
        void Run(UserModel user);
    }
}
