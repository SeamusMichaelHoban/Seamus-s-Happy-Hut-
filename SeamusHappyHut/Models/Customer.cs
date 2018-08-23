using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeamusHappyHut.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [DisplayName("Name")]
        public string CustomerName { get; set; }
        [DisplayName("Email")]
        public string CustomerEmail { get; set; }
        [DisplayName("Phone Number")]
        public string CustomerPhoneNumber { get; set; }
        [DisplayName("Favorite Drink")]
        public string FavoriteDrink { get; set; }
        [DisplayName("Favorite Meal")]
        public string FavoriteMeal { get; set; }
        [DisplayName("Largest Bill")]
        public double LargestBill { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }

    }
}