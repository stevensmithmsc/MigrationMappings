//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MigrationMappings
{
    using System;
    using System.Collections.Generic;
    
    public partial class RefVal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefVal()
        {
            this.Maps = new HashSet<Map>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Area { get; set; }
        public string Description { get; set; }
        public string PARIS_code { get; set; }
        public string Data_Dic { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Map> Maps { get; set; }
        public virtual RefArea RefArea { get; set; }
    }
}
