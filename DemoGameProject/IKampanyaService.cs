using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGameProject
{
    public interface IKampanyaService
    {
        public void Add(Kampanya kampanya);
        public void Delete(Kampanya kampanya);
        public void Update(Kampanya kampanya);
        public int DiscountValue(Kampanya kampanya);
    }
}
