//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CmsShoppingCart
{
    using System;
    using System.Collections.Generic;
    
    public partial class ToolServiceUse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ToolServiceUse()
        {
            this.BMISClientProfiles = new HashSet<BMISClientProfile>();
            this.Locations = new HashSet<Location>();
            this.ClientTools = new HashSet<ClientTool>();
        }
    
        public short ClientID { get; set; }
        public string LocationID { get; set; }
        public int ToolType { get; set; }
        public string SerialNumber { get; set; }
        public string SoftwareVersionNumber { get; set; }
        public long ServiceFamily { get; set; }
        public long ServiceFunction { get; set; }
        public System.DateTime TransmittedOn { get; set; }
        public string ClientIP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BMISClientProfile> BMISClientProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientTool> ClientTools { get; set; }
    }
}
