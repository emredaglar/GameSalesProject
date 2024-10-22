using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Abstract
{
    public interface IGameService
    {
        void Game_Add(Product product);
        void Game_Delete(Product product);
        void Game_Update(Product product);
    }
}
