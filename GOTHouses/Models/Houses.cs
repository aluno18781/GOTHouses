﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GOTHouses.Models
{
    public class Houses
    {
        public Houses()
        {
            CharactersList = new HashSet<Characters>();

        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Symbol { get; set; }



        public virtual ICollection<Characters> CharactersList { get; set; }

    }
}