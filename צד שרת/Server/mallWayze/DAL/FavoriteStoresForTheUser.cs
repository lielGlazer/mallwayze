//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class FavoriteStoresForTheUser
    {
        public long UserCode { get; set; }
        public long CodeStor { get; set; }
        public bool LikeStor { get; set; }
    
        public virtual Stor Stor { get; set; }
        public virtual Users Users { get; set; }
    }
}
