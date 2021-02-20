using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class EDevletManager: ICheckService
    {
        public bool Check(Gamer gamer)
        {
            if (gamer.TcNo=="1111" && gamer.FirstName=="Halil" && gamer.LastName=="Can" && DateTime.Compare(gamer.Birth, new DateTime(1997, 1, 1)) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
