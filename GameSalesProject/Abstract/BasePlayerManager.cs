using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Player_Add(Player player)
        {
            Console.WriteLine("Oyuncu Eklendi.: "+ player.FirstName);
        }

        public void Player_Delete(Player player)
        {
            Console.WriteLine("Oyuncu Silindi.: " + player.FirstName);
        }

        public virtual void Player_Update(Player player)
        {
            Console.WriteLine("Oyuncu Güncellendi.: " + player.FirstName);
        }
    }
}   
