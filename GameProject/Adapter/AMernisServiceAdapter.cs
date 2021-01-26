using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;
using GameProject.MernisServiceReference;

namespace GameProject.Adapter
{
    public class AMernisServiceAdapter : IGamerCheckService
    {
        public bool CheckTCMember(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            var valid = client.TCKimlikNoDogrula(
                Convert.ToInt64(gamer.NationalID), 
                gamer.Name.ToUpper(),
                gamer.Surname.ToUpper(), 
                gamer.BirthDate.Year);
            return valid;
        }
    }
}
