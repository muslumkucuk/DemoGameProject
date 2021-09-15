using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGameProject
{
    public class OrderManager : IOrderService
    {
        public void Sell(Game game,Gamer gamer,Kampanya kampanya)
        {
            game.PriceAfterDiscount = game.Price * (kampanya.IndirimOrani / 100) + game.Price;
            Console.WriteLine("Oyun " + gamer.FirstName +" adli oyuncuya " + game.PriceAfterDiscount + " TL fiyatına satıldı.");
        }
    }
}
