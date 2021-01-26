using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void StartCampaign(Campaign campaign)
        {
            if (campaign.GameName == "StarCitizen")
            {
                Console.WriteLine("Don't wait for this event StarCitizen will never be release");
                campaign.Active = false;
            }
            else
            {
                Console.WriteLine(campaign.CampaignName + " has started for " + campaign.GameName);
                campaign.Active = true;
            }

        }

        public virtual void JoinGamers(Campaign campaign, List<Gamer> gamers)
        {
            Console.WriteLine("Campaign Join Notification :: ");
        }
    }
}
