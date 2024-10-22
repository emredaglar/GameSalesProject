using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Abstract
{
    public interface ISaleService
    {
        void Buy(Player player, Product product,Campaign campaign) ;
    }
}
