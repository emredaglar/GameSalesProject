using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Campaign_Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Campaign_Remove(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Campaign_Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
