using ConsoleAppInterfaces.Models;
using System;
using System.Collections.Generic;

namespace ConsoleAppInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var listOfApps = GetApps();
            var user = GetUser();
            foreach (var app in listOfApps)
            {
                app.Run(user);
                if (app is MobileAppModel mobile)
                {
                    Console.WriteLine($"Mobile app recognized! {mobile.Name} has {mobile.Size}MB size and starts in {mobile.StartTimeOnMobileDevice} sec on mobile device");
                }
            }
            Console.ReadLine();
        }

        private static UserModel GetUser()
        {
            return new UserModel() { Name = "John", Surname = "Smith", City = "New York" };
        }

        private static List<IAppModel> GetApps()
        {
            var listOfApps = new List<IAppModel>();
            listOfApps.Add(new DesktopAppModel() { Name = "Simple deskop app" });
            listOfApps.Add(new MobileAppModel() { Name = "Advanced mobile app" });
            listOfApps.Add(new WebAppModel() { Name = "Normal web app" });
            return listOfApps;
        }
    }
}
