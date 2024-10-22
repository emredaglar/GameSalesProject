using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Buy(Player player, Product product,Campaign campaign)
        {
            Console.WriteLine(player.FirstName+ " Adlı Oyuncuya "+product.ProductName+" Adlı Oyun "+campaign.Campaign_Name+" Kampanyası Uygulanarak"+" Satıldı");
        }
    }
}
