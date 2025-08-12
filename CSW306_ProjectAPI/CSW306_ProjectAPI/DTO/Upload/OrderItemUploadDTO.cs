﻿using System.ComponentModel.DataAnnotations;

namespace CSW306_ProjectAPI.DTO.Upload
{
    public class OrderItemUploadDTO
    {
        [Required]
        public int ItemId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
