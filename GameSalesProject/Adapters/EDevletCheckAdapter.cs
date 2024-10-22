using EDevletServiceReference;
using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Adapters
{
    public class EDevletCheckAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId), player.FirstName, player.LastName, player.Date.Year);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
