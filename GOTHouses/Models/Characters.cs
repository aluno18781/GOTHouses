﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GOTHouses.Models
{
    public class Characters
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Family { get; set; }

        public string Photo { get; set; }

        public string Video { get; set; }

        [ForeignKey("House")]
        public int HouseFK { get; set; }
        public virtual Houses House { get; set; }

    }
}