//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inspinia_MVC5_SeedProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MobileAd
    {
        public int Id { get; set; }
        public string mobileId { get; set; }
        public int adId { get; set; }
        public string color { get; set; }
        public string condition { get; set; }
        public Nullable<int> sims { get; set; }
    
        public virtual Ad Ad { get; set; }
        public virtual Mobile Mobile { get; set; }
    }
}
