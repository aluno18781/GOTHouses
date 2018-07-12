using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GOTHouses.Models
{
        public class GOTHousesDB : DbContext
        {

            public GOTHousesDB() : base("GOTHousesDBConnectionString")
            {
            
            }

            public virtual DbSet<Houses> Houses { get; set; }
            public virtual DbSet<Characters> Characters { get; set; }
        }    
}