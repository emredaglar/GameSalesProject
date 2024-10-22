using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class PlayerCheckTestManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
