//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankaYonetimSistemi
{
    using System;
    using System.Collections.Generic;
    
    public partial class temsilciler
    {
        public int temsilciID { get; set; }
        public int tid { get; set; }
        public int kID { get; set; }
    
        public virtual kullanicilar kullanicilar { get; set; }
    }
}
