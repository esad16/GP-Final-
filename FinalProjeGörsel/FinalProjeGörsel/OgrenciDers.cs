//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProjeGörsel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OgrenciDers
    {
        public int Id { get; set; }
        public int Ders_Id { get; set; }
        public int Ogrenci_Id { get; set; }
    
        public virtual Ders Ders { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
