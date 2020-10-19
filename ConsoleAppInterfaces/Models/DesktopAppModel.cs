using System;

namespace ConsoleAppInterfaces.Models
{
    public class DesktopAppModel : IAppModel
    {
        public string Name { get; set; }
        public int Size { get; private set; }

        public void Run(UserModel user)
        {
            Size = 250;
            Console.WriteLine($"User {user.Name} {user.Surname} from {user.City} got a desktop app");
        }
    }
}
