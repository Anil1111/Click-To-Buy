﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClickToBuy.Model
{
    public class ReturnProduct
    {
        public int Id { get; set; }

        [Required] 
        [Display(Name = "Provied order number.")]
        public int OrderId { get; set; }

        [Required]
        [Display(Name = "Provied product name.")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Provied quantity.")]
        [Range(1, 5)]
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }


    }
}
