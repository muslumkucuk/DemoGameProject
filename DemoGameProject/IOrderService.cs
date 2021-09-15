using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGameProject
{
    public interface IOrderService
    {
        public void Sell(Game game, Gamer gamer, Kampanya kampanya);
    }
}
