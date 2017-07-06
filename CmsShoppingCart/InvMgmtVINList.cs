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
    
    public partial class InvMgmtVINList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvMgmtVINList()
        {
            this.BMISClientProfiles = new HashSet<BMISClientProfile>();
            this.Locations = new HashSet<Location>();
            this.Locations1 = new HashSet<Location>();
            this.LocationsVehicles = new HashSet<LocationsVehicle>();
        }
    
        public short ClientID { get; set; }
        public string LocationID { get; set; }
        public string VinNumber { get; set; }
        public System.DateTime PilotDate { get; set; }
        public System.DateTime OrigDeliveryDate { get; set; }
        public System.DateTime GoLiveDate { get; set; }
        public string DecisionCatagoryOverride { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BMISClientProfile> BMISClientProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationsVehicle> LocationsVehicles { get; set; }
    }
}