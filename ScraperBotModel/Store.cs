//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScraperBotModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            this.Link = new HashSet<Link>();
            this.Product = new HashSet<Product>();
            this.BadWords = new HashSet<BadWords>();
        }
    
        public int idStore { get; set; }
        public string name { get; set; }
        public string baseUrl { get; set; }
        public string titleSelector { get; set; }
        public string originalPriceSelector { get; set; }
        public string salePriceSelector { get; set; }
        public string currency { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Link> Link { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BadWords> BadWords { get; set; }
    }
}