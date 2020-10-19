using System;

namespace ConsoleAppInterfaces.Models
{
    public class MobileAppModel : IAppModel
    {
        public int StartTimeOnMobileDevice { get; private set; }
        public string Name { get; set; }
        public int Size { get; private set; }

        public void Run(UserModel user)
        {
            Size = 100;
            StartTimeOnMobileDevice = 7;
            Console.WriteLine($"User {user.Name} {user.Surname} from {user.City} got a mobile app");
        }
    }
}
