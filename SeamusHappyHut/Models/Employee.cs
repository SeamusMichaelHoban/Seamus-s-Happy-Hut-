using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeamusHappyHut.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [DisplayName ("Name")]
        public string EmployeeName { get; set; }
        [DisplayName ("Email")]
        public string EmployeeEmail { get; set; }
        public string PhoneNumber { get; set; }
        [DisplayName ("ID Number")]
        public string EmployeeNumber { get; set; }
        [DisplayName ("Emergency Contact")]
        public string EmployeeEmergencyContactName { get; set; }
        [DisplayName ("Emergency Contact Phone Number")]
        public string EmployeeEmergencyNumber { get; set; }

        public DateTime DateStarted { get; set; }
    }
}