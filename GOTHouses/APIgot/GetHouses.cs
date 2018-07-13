using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GOTHouses.APIgot
{
    public class GetHouses
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Symbol { get; set; }

       /* public virtual ICollection<Characters> CharactersList { get; set; }

        public class Characters
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string Family { get; set; }

            public string Photo { get; set; }

            public string Video { get; set; }
        }*/
    }
}