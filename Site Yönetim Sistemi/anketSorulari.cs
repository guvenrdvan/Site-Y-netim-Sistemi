//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Site_Yönetim_Sistemi
{
    using System;
    using System.Collections.Generic;
    
    public partial class anketSorulari
    {
        public int id { get; set; }
        public string soru { get; set; }
        public Nullable<int> anketId { get; set; }
    
        public virtual anket anket { get; set; }
    }
}
