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
    
    public partial class Equipment
    {
        public int Code { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public double Rent_Price { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public string Administrator { get; set; }
    
        public virtual Administrator Administrator1 { get; set; }
        public virtual EquipmentCategory EquipmentCategory { get; set; }
        public virtual EquipmentOrder EquipmentOrder { get; set; }
        public virtual UserOrder UserOrder { get; set; }
    }
}
