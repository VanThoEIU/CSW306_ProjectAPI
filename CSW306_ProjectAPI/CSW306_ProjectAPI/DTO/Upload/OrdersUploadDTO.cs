﻿using System.ComponentModel.DataAnnotations;

namespace CSW306_ProjectAPI.DTO.Upload
{
    public class OrdersUploadDTO
    {
        [Required]
        public int Status { get; set; }

        [Required]
        public List<OrderItemUploadDTO> Items { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
