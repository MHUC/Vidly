﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool AddIsSubscribedToCustomer { get; set; }

      
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Types")]
        public byte MembershipTypeId { get; set; }

        [Display(Name= "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        // public List<Customer> Customers { get; set; }
    }
}