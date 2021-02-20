using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Gamer:IEntity
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string TcNo { get; set; }


    }
}
