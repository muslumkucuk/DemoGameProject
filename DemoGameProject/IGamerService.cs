using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGameProject
{
    public interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Update(Gamer gamer);
        public void Delete(Gamer gamer);

    }
}
