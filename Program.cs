using System;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() {Id = 1,FirstName = "Halil",LastName = "Can",TcNo = "1111",Birth = new DateTime(1997,1,1)};

            GamerManager gamerManager = new GamerManager(new EDevletManager());
            gamerManager.Add(gamer);

            gamerManager.Delete(gamer);

            Game game = new Game(){Id = 1,GameName = "Counter",Price = 10};
            Campaign campaign = new Campaign(){Id = 1,CampaignName = "Kampanya1",CampaignPrice = 8};

            SaleManager saleManager = new SaleManager();

                saleManager.Sale(gamer,game);
                saleManager.CampaignSale(gamer,game,campaign);




        }
    }
}
