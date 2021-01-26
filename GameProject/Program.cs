using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogService logManager = new BaseLogManager();
            IGamerService gamerManager = new GamerRegisterManager(new AMernisServiceAdapter(), logManager);
            ICampaignService campaignManager = new CampaignStartManager();
            List<Gamer> registeredGamers = new List<Gamer>();

            #region Creating Gamers

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.Name = "Ferhat";
            gamer1.Surname = "OYGUR";
            gamer1.BirthDate = new DateTime(1881, 1, 1);
            gamer1.NationalID = "99999999999";
            gamer1.Professionality = "MMO-ARPG";
            gamer1.Registered = false;

            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                Name = "Dilek",
                Surname = "OYGUR",
                BirthDate = new DateTime(1919, 5, 19),
                NationalID = "99999999999",
                Professionality = "Real Time Strategy",
                Registered = false
            };

            Gamer gamer3 = new Gamer()
            {
                Id = 3,
                Name = "Esila",
                Surname = "OYGUR",
                BirthDate = new DateTime(1920, 4, 23),
                NationalID = "99999999999",
                Professionality = "Sandbox",
                Registered = false
            };

            Gamer gamer4 = new Gamer()
            {
                Id = 4,
                Name = "Ali Alp",
                Surname = "OYGUR",
                BirthDate = new DateTime(1923, 10, 29),
                NationalID = "99999999999",
                Professionality = "Puzzle",
                Registered = false
            };

            #endregion

            #region Campaigns

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Steam Halloween Event";
            campaign1.GameName = "AA Games";
            campaign1.Platform = "PC";
            campaign1.Active = false;

            Campaign campaign2 = new Campaign()
            {
                Id = 2,
                CampaignName = "Global Game Jam Online 2021",
                GameName = "MOBA Games: Lol-HOTS-DOTA2",
                Platform = "PC, Console",
                Active = false
            };

            Campaign campaign3 = new Campaign()
            {
                Id = 3,
                CampaignName = "Origin & Intel Org ShowCase",
                GameName = "Star Wars:BattleFront II",
                Platform = "PC",
                Active = false
            };

            Campaign campaign4 = new Campaign()
            {
                Id = 4,
                CampaignName = "Roberts Space Industry",
                GameName = "StarCitizen",
                Platform = "PC",
                Active = false
            };


            #endregion

            gamerManager.Register(gamer1, registeredGamers);
            gamerManager.Register(gamer2, registeredGamers);
            gamerManager.Register(gamer3, registeredGamers);
            gamerManager.Register(gamer4, registeredGamers);

            campaignManager.StartCampaign(campaign1);
            campaignManager.StartCampaign(campaign2);
            campaignManager.StartCampaign(campaign4);

            campaignManager.JoinGamers(campaign3, registeredGamers);
            campaignManager.JoinGamers(campaign2, registeredGamers);
            campaignManager.JoinGamers(campaign1, registeredGamers);

            //herşeyi ayaraldıktan sonra burda istemsiz derin bir nefes aldım Start butonunun uzerinde beklerken
            //sonra bi baktım ReadLine eklememişim. ulan dedim noluyor.

            Console.ReadLine();
        }
    }
}
