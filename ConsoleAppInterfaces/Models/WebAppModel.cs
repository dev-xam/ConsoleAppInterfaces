using System;

namespace ConsoleAppInterfaces.Models
{
    public class WebAppModel : IAppModel
    {
        public bool IsResponsive { get; private set; }

        public string Name { get; set; }

        public int Size { get; private set; }

        public void Run(UserModel user)
        {
            IsResponsive = true;
            Size = 5;
            Console.WriteLine($"User {user.Name} {user.Surname} from {user.City} got a web app");
        }
    }
}