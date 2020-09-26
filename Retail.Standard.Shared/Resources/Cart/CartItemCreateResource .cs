﻿
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Retail.Standard.Shared.Resources.Cart
{
    public class CartItemCreateResource : CreateResource
    {
        [Required]
        [StringLength(37)]
        public string ProductId { get; set; }

        [Required]
        [Range(1, 10000)]
        public int Quantity { get; set; }
    }
}
