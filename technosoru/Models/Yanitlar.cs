//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace technosoru.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yanitlar
    {
        public int Yanitid { get; set; }
        public string YanitIcerik { get; set; }
        public System.DateTime YanitTarih { get; set; }
        public int yUyeid { get; set; }
        public int ySoruid { get; set; }
    
        public virtual Sorular Sorular { get; set; }
        public virtual Uyeler Uyeler { get; set; }
    }
}
