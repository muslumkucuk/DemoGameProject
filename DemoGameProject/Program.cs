using System;

namespace DemoGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerService gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            { 
                Id = 1,
                BirthYear = 1994,
                FirstName = "Müslüm",
                LastName = "Küçük",
                IdentityNumber=123456
            });
            Console.WriteLine("");

            Kampanya kampanya1 = new Kampanya();
            kampanya1.IndirimOrani = 50;

            
        }
    }
}
