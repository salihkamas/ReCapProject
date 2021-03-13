using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CustomerDetailDto:IDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
    }
}
