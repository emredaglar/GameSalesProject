using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Player_Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Player_Add(player);
            }
            else
            {
                throw new Exception("Not valid person");
            }

        }
        public override void Player_Update(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Player_Update(player);
            }
            else
            {
                throw new Exception("Not valid person");
            }
            
        }
    }
}
