using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Abstract
{
    public interface IPlayerService
    {
        void Player_Add(Player player);
        void Player_Update(Player player);
        void Player_Delete(Player player);
    }
}
