using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISaleService
    {

        void Sale(Gamer gamer,Game game);
        void CampaignSale(Gamer gamer, Game game, Campaign campaign);
    }
}
