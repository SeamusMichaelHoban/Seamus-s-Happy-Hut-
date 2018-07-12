using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeamusHappyHut.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string FavoriteDrink { get; set; }
        public string FavoriteMeal { get; set; }
        public double LargestBill { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }

    }
}