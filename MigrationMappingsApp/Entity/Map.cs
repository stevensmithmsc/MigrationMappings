//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MigrationMappingsApp.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Map
    {
        public int ID { get; set; }
        public string System { get; set; }
        public Nullable<int> Area { get; set; }
        public Nullable<int> Number { get; set; }
        public string Code { get; set; }
        public string Local_Description { get; set; }
        public Nullable<int> MapTo { get; set; }
    
        public virtual RefArea RefArea { get; set; }
        public virtual RefVal RefVal { get; set; }
    }
}
