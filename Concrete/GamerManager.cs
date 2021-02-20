using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerManager: IGamerService
    {
        private ICheckService _checkService;

        public GamerManager(ICheckService checkService)
        {
            _checkService = checkService;
        }

        public void Add(Gamer gamer)
        {
            if (_checkService.Check(gamer))
            {
                Console.WriteLine("Eklendi: "+gamer.FirstName);
            }
            else
            {
                throw new Exception("Eklenemedi");
            }



        }

            

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Silindi: "+gamer.FirstName);



        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellendi: "+gamer.FirstName);
        }

    }
}
