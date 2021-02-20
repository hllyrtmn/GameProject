using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SaleManager:ISaleService
    {

        public void Sale(Gamer gamer,Game game)
        {
            Console.WriteLine("{0} oyuncu {1} oyununu satın aldı",gamer.FirstName,game.GameName);

        }

        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            var newPrice = game.Price - campaign.CampaignPrice;
            Console.WriteLine("Kampanyalı fiyat "+newPrice+" 'dır");
        }

    }
}
