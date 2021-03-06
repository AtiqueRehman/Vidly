﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribeToNewletters { get; set; }
        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }
    }
}