using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class CampaignStartManager : BaseCampaignManager
    {
        public override void JoinGamers(Campaign campaign, List<Gamer> gamers)
        {
            if (campaign.Active)
            {
                base.JoinGamers(campaign, gamers);
                //bu calısmayı nerde yapacagımdan tam emin olamadım ama basede yapmak dogru olmaz diye düsünüp
                //bu tarafa aldım 
                foreach (var xgamer in gamers)
                {
                    Console.WriteLine(xgamer.Name + " Joined " + campaign.CampaignName);
                }
            }
            else
            {
                Console.WriteLine("{0} isn't Active Join Request Denied. ", campaign.CampaignName);
            }

        }
    }
}
