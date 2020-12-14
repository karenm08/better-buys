﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuys.Models
{
    public class CheckoutInfo : BaseEntity
    {
        public int CartId { get; private set; }
        public string ShippingAddress { get; private set; }
        [Phone]
        [Required]
        public string Phone { get; set; }
        [StringLength(12)]
        [Required]
        public string CardNumber { get; set; }
        [StringLength(100, MinimumLength = 10)]
        [Required]
        public string CardHolderName { get; set; }
        [StringLength(100, MinimumLength = 10)]
        [Required]
        public string ExpirationDate { get; set; }
        [StringLength(3)]
        [Required]
        public string CVW { get; set; }

        public virtual ShoppingCart Cart { get; set; }
    }
}