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
    
    public partial class ToolAuthorization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ToolAuthorization()
        {
            this.BMISClientProfiles = new HashSet<BMISClientProfile>();
            this.ClientTools = new HashSet<ClientTool>();
        }
    
        public string SerialNumber { get; set; }
        public short ClientID { get; set; }
        public System.Guid AuthorizationCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BMISClientProfile> BMISClientProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientTool> ClientTools { get; set; }
    }
}