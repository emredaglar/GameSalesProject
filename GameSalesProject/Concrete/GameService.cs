using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class GameService : IGameService
    {
        public void Game_Add(Product product)
        {
            Console.WriteLine("Oyun Eklendi: "+product.ProductName);
        }

        public void Game_Delete(Product product)
        {
            Console.WriteLine("Oyun Eklendi: " + product.ProductName);
        }

        public void Game_Update(Product product)
        {
            Console.WriteLine("Oyun Eklendi: " + product.ProductName);
        }
    }
}
