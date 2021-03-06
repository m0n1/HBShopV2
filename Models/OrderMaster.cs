﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace HBShop.Models
{
    public class OrderMaster
    {
        public long OrderMasterId { get; set; }
        public virtual Client Client { get; set; }
        public float TotalAmount { get; set; }
        public float Received { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderDetail> Details { get; set; }
        public DateTime Date { get; set; }
        public virtual ApplicationUser User { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; }

        public enum OrderStatus
        {
            Ordered =0,
            Paid,
            Delivered,
            Shipped
        }
    }

    public class Order
    {
        public OrderMaster   OrderMAster { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}