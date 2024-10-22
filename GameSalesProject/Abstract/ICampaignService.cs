using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Abstract
{
    public interface ICampaignService
    {
        void Campaign_Add(Campaign campaign);
        void Campaign_Remove(Campaign campaign);
        void Campaign_Update(Campaign campaign);
    }
}
