using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeamusHappyHut.Models
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }

    }
}