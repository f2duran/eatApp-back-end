//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eatApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class takipci_Tablosu
    {
        public string takipId { get; set; }
        public string takipEdenUyeId { get; set; }
        public string takipEdilenUyeId { get; set; }
    
        public virtual uye_Tablosu uye_Tablosu { get; set; }
        public virtual uye_Tablosu uye_Tablosu1 { get; set; }
    }
}
