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
    
    public partial class EquipmentCategory
    {
        public EquipmentCategory()
        {
            this.Equipment = new HashSet<Equipment>();
        }
    
        public int id_ { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
