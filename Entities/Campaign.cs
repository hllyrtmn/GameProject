using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Campaign: IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CampaignPrice { get; set; }



    }
}
