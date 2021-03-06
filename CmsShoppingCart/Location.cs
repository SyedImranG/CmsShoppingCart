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
    
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            this.BMISClientProfiles = new HashSet<BMISClientProfile>();
        }
    
        public short OEMID { get; set; }
        public string LocationID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string LocAddress { get; set; }
        public string LocCity { get; set; }
        public string LocState { get; set; }
        public string LocZip { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public System.Data.Entity.Spatial.DbGeography GeoLocation { get; set; }
        public string Region { get; set; }
        public int InActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BMISClientProfile> BMISClientProfiles { get; set; }
        public virtual InvMgmtVINList InvMgmtVINList { get; set; }
        public virtual InvMgmtVINList InvMgmtVINList1 { get; set; }
        public virtual Tests_Core Tests_Core { get; set; }
        public virtual ToolServiceUse ToolServiceUse { get; set; }
        public virtual RegionTree RegionTree { get; set; }
    }
}
