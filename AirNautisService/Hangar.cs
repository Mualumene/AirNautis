//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirNautisService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hangar
    {
        public Hangar()
        {
            this.Airplane = new HashSet<Airplane>();
        }
    
        public int Number { get; set; }
        public int Capacity { get; set; }
    
        public virtual ICollection<Airplane> Airplane { get; set; }
    }
}
