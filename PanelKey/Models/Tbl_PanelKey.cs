//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PanelKey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_PanelKey
    {
        public int PanelKeyId { get; set; }
        public Nullable<int> PanelId { get; set; }
        public Nullable<int> KeyId { get; set; }
    
        public virtual Tbl_Key Tbl_Key { get; set; }
        public virtual Tbl_Panel Tbl_Panel { get; set; }
    }
}