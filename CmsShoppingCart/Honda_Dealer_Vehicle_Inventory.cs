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
    
    public partial class Honda_Dealer_Vehicle_Inventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Honda_Dealer_Vehicle_Inventory()
        {
            this.LocationsVehicles = new HashSet<LocationsVehicle>();
        }
    
        public string VIN { get; set; }
        public string TRIM { get; set; }
        public string COLOR { get; set; }
        public Nullable<System.DateTime> MANUFACTURED_DATE { get; set; }
        public string MANUFACTURED_PLANT { get; set; }
        public string DIVISION { get; set; }
        public string DEALER_CODE { get; set; }
        public System.DateTime RECEIVED_DATE { get; set; }
        public string STOCK_NUMBER { get; set; }
        public Nullable<System.DateTime> SOLD_DATE { get; set; }
        public System.DateTime RPT_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationsVehicle> LocationsVehicles { get; set; }
    }
}
