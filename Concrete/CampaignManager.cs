using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Güncellendi");
        }
    }
}
