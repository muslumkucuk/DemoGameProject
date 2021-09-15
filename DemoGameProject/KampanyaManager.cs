using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGameProject
{
    public class KampanyaManager : IKampanyaService
    {
        public void Add(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya eklendi.");
        }

        public void Delete(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
        public int DiscountValue(Kampanya kampanya)
        {
            return kampanya.IndirimOrani;
        }
    }
}
