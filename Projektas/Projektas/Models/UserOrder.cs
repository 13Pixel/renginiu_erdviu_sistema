//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projektas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserOrder
    {
        public UserOrder()
        {
        }

        public UserOrder(int orderCode, int reservationId)
        {
            Random rnd = new Random();
            this.Date = DateTime.Now;
            this.is_Paid = false;
            this.Sum = rnd.Next(100, 201);
            this.Order_code = orderCode;
            this.Reservation = reservationId;
        }
    
        public int Order_code { get; set; }
        public System.DateTime Date { get; set; }
        public double Sum { get; set; }
        public bool is_Paid { get; set; }
        public int Reservation { get; set; }


    
        public virtual ICollection<Equipment> Equipment { get; set; }
        public virtual ICollection<FoodOrder> FoodOrder { get; set; }
        public virtual ICollection<EquipmentOrder> EquipmentOrder { get; set; }
        public virtual Reservation Reservation1 { get; set; }
    }
}
