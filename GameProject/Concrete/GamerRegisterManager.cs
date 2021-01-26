using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class GamerRegisterManager : BaseGamerManager
    {
        IGamerCheckService _gamerCheckService;
        private ILogService _logService;

        public GamerRegisterManager(IGamerCheckService gamerCheckService, ILogService logService)
        {
            _gamerCheckService = gamerCheckService;
            _logService = logService;
        }

        public override void Register(Gamer gamer, List<Gamer> registeredGamers)
        {
            if (_gamerCheckService.CheckTCMember(gamer))
            {
                gamer.Registered = true;
                base.Register(gamer, registeredGamers);
                registeredGamers.Add(gamer);
                _logService.LogSuccess(gamer);
            }
            else
            {
                Console.WriteLine("Registration failed. Because " + gamer.Name + " " + gamer.Surname + " couldn't validated by TC Government\nPlease check your register information");
                //burda mesaj vermeye cokta gerek yok aslında detaylı mesajı log servisinde verebiliriz.
                _logService.LogAttempt(gamer);
            }

        }
    }
}
