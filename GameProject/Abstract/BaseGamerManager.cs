using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public abstract class BaseGamerManager:IGamerService
    {
        public virtual void Register(Gamer gamer, List<Gamer> registeredGamers)
        {
            Console.WriteLine(gamer.Name + " Registered Under " + gamer.Professionality + " Section");
        }
    }
}
